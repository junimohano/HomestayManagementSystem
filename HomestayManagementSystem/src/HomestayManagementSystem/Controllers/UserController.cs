using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HomestayManagementSystem.Database;
using HomestayManagementSystem.Models;
using HomestayManagementSystem.Utils;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HomestayManagementSystem.Controllers
{
    public class UserController : BaseController
    {
        private readonly HomestayContext _context;

        public UserController(HomestayContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult List()
        {
            SetProfile();
            return View("UserList");
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Forbidden()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.Authentication.SignOutAsync(ConstValue.AuthenticationScheme);

            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        public IActionResult UserDetailPartial(int userId)
        {
            User user;
            if (userId == 0)
                user = new User();
            else
            {
                user = _context.Users.Include(x => x.UserSiteLocations).ThenInclude(x1 => x1.SiteLocation)
                    .FirstOrDefault(x => x.UserId == userId);
                user.Password = ConstValue.DefaultPassword;
            }
            ViewData["UserSiteLocations"] = GetUserSiteLocations(user.UserId);
            ViewData["PermissionId"] = PermissionId;
            ViewData["UserId"] = UserId;

            return PartialView("UserDetail", user);
        }

        public IActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            var users =
                _context.Users
                    .Include(x => x.CreatedUser)
                    .Include(x => x.UpdatedUser)
                    .Include(x => x.Permission)
                    .Where(x => x.UserSiteLocations.Select(x1 => x1.SiteLocationId).Intersect(SiteLocations).Any())
                    .AsNoTracking()
                    .Select(x => new User()
                    {
                        UserId = x.UserId,
                        LoginId = x.LoginId,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Permission = x.Permission,
                        IsActive = x.IsActive,
                        CreatedDate = x.CreatedDate,
                        CreatedUserName = ConstValue.GetUserName(x.CreatedUser),
                        UpdatedDate = x.UpdatedDate,
                        UpdatedUserName = ConstValue.GetUserName(x.UpdatedUser)
                    })
                    .OrderByDescending(x => x.UserId);

            return Json(users.ToDataSourceResult(request));
        }

        //[Authorize(Roles = nameof(ConstValue.PermissionType.Admin) + ", " + nameof(ConstValue.PermissionType.Developer))]
        [HttpPost]
        public IActionResult SetUser(User user, string selectedUserSiteLocations)
        {
            var isAdd = user.UserId == 0;
            if (!isAdd)
            {
                ModelState.Remove("LoginId");
                if (user.Password == ConstValue.DefaultPassword)
                    ModelState.Remove("Password");
            }

            try
            {
                if (ModelState.IsValid)
                {
                    var tempUserSiteLocations = new List<UserSiteLocation>();
                    if (selectedUserSiteLocations != null)
                    {
                        foreach (var s in selectedUserSiteLocations.Split(','))
                        {
                            tempUserSiteLocations.Add(new UserSiteLocation()
                            {
                                UserId = UserId,
                                CreatedDate = DateTime.Now,
                                CreatedUserId = UserId,
                                SiteLocationId = Convert.ToInt32(s)
                            });
                        }
                    }

                    if (isAdd)
                    {
                        if (tempUserSiteLocations.Count > 0)
                            user.UserSiteLocations = tempUserSiteLocations;

                        user.CreatedUserId = UserId;
                        _context.Users.Add(user);
                    }
                    else
                    {
                        if (PermissionId == (int)ConstValue.PermissionType.User)
                        {
                            var updateUser = _context.Users.FirstOrDefault(x => x.UserId == user.UserId && x.UserId == UserId);
                            if (updateUser != null)
                            {
                                if (user.Password != ConstValue.DefaultPassword)
                                    updateUser.Password = ConstValue.GetHash(user.Password);
                                updateUser.UpdatedUserId = UserId;
                                updateUser.UpdatedDate = DateTime.Now;
                            }
                            else
                            {
                                throw new Exception("Do not have a permissions");
                            }
                        }
                        else
                        {
                            _context.UserSiteLocations.RemoveRange(_context.UserSiteLocations.Where(x => x.UserId == user.UserId));
                            _context.SaveChanges();

                            var updateUser = _context.Users.Include(x => x.UserSiteLocations).FirstOrDefault(x => x.UserId == user.UserId);
                            updateUser.FirstName = user.FirstName;
                            updateUser.LastName = user.LastName;
                            if (user.Password != ConstValue.DefaultPassword)
                                updateUser.Password = ConstValue.GetHash(user.Password);
                            if (user.Remark != null)
                                updateUser.Remark = user.Remark;
                            updateUser.IsActive = user.IsActive;
                            if (tempUserSiteLocations.Count > 0)
                                updateUser.UserSiteLocations = tempUserSiteLocations;
                            updateUser.PermissionId = user.PermissionId;
                            updateUser.UpdatedUserId = UserId;
                            updateUser.UpdatedDate = DateTime.Now;
                        }
                    }
                    _context.SaveChanges();

                    ViewData["IsResult"] = true;
                }
                else
                    ModelState.AddModelError(string.Empty, string.Join(" ", ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage)));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            ViewData["UserSiteLocations"] = GetUserSiteLocations(user.UserId);
            ViewData["PermissionId"] = PermissionId;
            ViewData["UserId"] = UserId;

            return PartialView("UserDetail", user);
        }

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            var u = _context.Users
                .Include(x => x.UserSiteLocations)
                    .ThenInclude(x => x.SiteLocation)
                .Include(x => x.Permission)
                .FirstOrDefault(x => x.LoginId.ToLower() == user.LoginId.ToLower() && x.Password == ConstValue.GetHash(user.Password) && x.IsActive);

            if (u != null)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ConstValue.UserIdKey, u.UserId.ToString()),
                    new Claim(ConstValue.PermissionIdKey, u.PermissionId.ToString()),
                    new Claim(ConstValue.UserInfoKey, $"{u.FirstName} {u.LastName} ({u.Permission.Name})")
                };
                claims.AddRange(u.UserSiteLocations.Select(userSiteLocation => new Claim(ConstValue.SiteLocationsKey, userSiteLocation.SiteLocationId.ToString())));

                var identity = new ClaimsIdentity(claims, "Forms");
                identity.AddClaim(new Claim(ClaimTypes.Role, u.Permission.Name));
                var principal = new ClaimsPrincipal(identity);

                await HttpContext.Authentication.SignInAsync(ConstValue.AuthenticationScheme, principal);

                _context.LoginHistorys.Add(new LoginHistory()
                {
                    CreatedUserId = u.UserId,
                    IpAddress = HttpContext.Connection.RemoteIpAddress.ToString()
                });
                _context.SaveChanges();
                //HttpContext.Session.SetInt32(ConstValue.UserIdSessionKey, u.UserId);
                //HttpContext.Session.SetString(ConstValue.SiteLocationsSessionKey, JsonConvert.SerializeObject(u.UserSiteLocations.Select(x => x.SiteLocationId)));

                return RedirectToAction("List", "HomestayStudent");
            }
            else
            {
                ModelState.AddModelError("", "LoginId or Password is wrong");
            }

            return View();
        }

        public IEnumerable<TreeViewItemModel> GetUserSiteLocations(int userId)
        {
            var treeViewItemModels = new List<TreeViewItemModel>();

            var selectedUserSiteLocations = GetSelectedUserSiteLocations(userId);
            var availableUserSiteLocations = GetAvailableUserSiteLocations(userId);

            treeViewItemModels.AddRange(selectedUserSiteLocations);

            foreach (var a in availableUserSiteLocations)
            {
                var t = treeViewItemModels.FirstOrDefault(x => x.Text == a.Text);
                if (t == null)
                    treeViewItemModels.Add(a);
                else
                    t.Items.AddRange(a.Items);
            }
            return treeViewItemModels;
        }

        private IEnumerable<TreeViewItemModel> GetSelectedUserSiteLocations(int userId)
        {
            var userSiteLocations =
                _context.UserSiteLocations
                    .Include(x => x.SiteLocation)
                        .ThenInclude(x => x.Site)
                    .Where(x => x.UserId == userId)
                    .AsNoTracking()
                    .ToList();

            var sites = new List<int>();
            var treeViewItemModels = new List<TreeViewItemModel>();
            foreach (var u in userSiteLocations)
            {
                if (sites.Any(x => x == u.SiteLocation.Site.SiteId)) continue;

                sites.Add(u.SiteLocation.Site.SiteId);
                treeViewItemModels.Add(new TreeViewItemModel()
                {
                    Text = u.SiteLocation.Site.Name,
                    Id = 0.ToString(),
                    Items = u.SiteLocation.Site.SiteLocations.Select(x => new TreeViewItemModel()
                    {
                        Id = x.SiteLocationId.ToString(),
                        Text = x.Name,
                        Checked = true
                    }).ToList()
                });
            }

            return treeViewItemModels;
        }

        private IEnumerable<TreeViewItemModel> GetAvailableUserSiteLocations(int userId)
        {
            var userSiteLocations =
             _context.SiteLocations
                 .Include(x => x.UserSiteLocations)
                 .Include(x => x.Site)
                 .Where(x => !x.UserSiteLocations.Select(x1 => x1.UserId).Contains(userId))
                 .AsNoTracking()
                 .ToList();

            var sites = new List<int>();
            var treeViewItemModels = new List<TreeViewItemModel>();
            foreach (var u in userSiteLocations)
            {
                if (sites.Any(x => x == u.Site.SiteId)) continue;

                sites.Add(u.Site.SiteId);
                treeViewItemModels.Add(new TreeViewItemModel()
                {
                    Text = u.Site.Name,
                    Id = 0.ToString(),
                    Items = u.Site.SiteLocations.Select(x => new TreeViewItemModel()
                    {
                        Id = x.SiteLocationId.ToString(),
                        Text = x.Name
                    }).ToList()
                });
            }

            return treeViewItemModels;

            //var treeViewItemModels =
            //        _context.Sites
            //        .Include(x => x.SiteLocations)
            //            .ThenInclude(x => x.UserSiteLocations)
            //        .Where(x => x.SiteLocations.Select(x1 => x1.UserSiteLocations.Select(x2 => x2.UserId).Contains(userId)).Contains(false))
            //        .AsNoTracking()
            //        .Select(x => new TreeViewItemModel()
            //        {
            //            Text = x.Name,
            //            Id = 0.ToString(),
            //            Items = x.SiteLocations.Select(x1 => new TreeViewItemModel()
            //            {
            //                Id = x1.SiteLocationId.ToString(),
            //                Text = x1.Name
            //            }).ToList()
            //        }).ToList();
        }

    }
}

