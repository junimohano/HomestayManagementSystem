using System;
using System.Collections.Generic;
using System.Linq;
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
    public class HomestayStudentController : BaseController
    {
        private readonly HomestayContext _context;

        public HomestayStudentController(HomestayContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult List()
        {
            SetProfile();
            return View("HomestayStudentList");
        }

        public IActionResult HomestayStudentDetailPartial(int homestayStudentId)
        {
            HomestayStudent homestayStudent;
            if (homestayStudentId == 0)
                homestayStudent = new HomestayStudent();
            else
            {
                homestayStudent =
                    _context.HomestayStudents
                            .Include(x => x.Student)
                                .ThenInclude(x1 => x1.SiteLocation)
                            .FirstOrDefault(x => x.HomestayStudentId == homestayStudentId);

                homestayStudent.SiteId = homestayStudent.Student.SiteLocation.SiteId;
                homestayStudent.SiteLocationId = homestayStudent.Student.SiteLocationId;
            }

            ViewData["PermissionId"] = PermissionId;

            return PartialView("HomestayStudentDetail", homestayStudent);
        }

        public IActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            IEnumerable<HomestayStudent> homestayStudents =
                _context.HomestayStudents
                    .Include(x => x.Homestay)
                        .ThenInclude(x => x.HomestayEvaluations)
                    .Include(x => x.Homestay)
                    .Include(x => x.Student)
                        .ThenInclude(x => x.SiteLocation)
                        .ThenInclude(x => x.Site)
                    .Where(x => SiteLocations.Contains(x.Student.SiteLocationId))
                    .AsNoTracking()
                    .Select(x => new HomestayStudent
                    {
                        HomestayStudentId = x.HomestayStudentId,
                        Arrival = x.Arrival,
                        Departure = x.Departure,
                        SiteName = x.Student.SiteLocation.Site.Name,
                        SiteLocationName = x.Student.SiteLocation.Name,
                        HomestayFamily = ConstValue.GetHomestayFamilyName(x.Homestay),
                        Homestay = x.Homestay,
                        Student = x.Student,
                        DueDate = x.DueDate,
                        Amount = x.Amount,
                        PaidDate = x.PaidDate,
                        PaidAmount = x.PaidAmount,
                        Balance = x.PaidAmount - x.Amount,
                        Remark = x.Remark,
                        IsActive = x.IsActive,
                        IsContractSigned = x.Homestay.HomestayContracts.Any(),
                        CreatedDate = x.CreatedDate,
                        CreatedUserName = ConstValue.GetUserName(x.CreatedUser),
                        UpdatedDate = x.UpdatedDate,
                        UpdatedUserName = ConstValue.GetUserName(x.UpdatedUser)
                    })
                    .OrderByDescending(x => x.HomestayStudentId);

            return Json(homestayStudents.ToDataSourceResult(request));
        }

        [HttpPost]
        public IActionResult SetHomestayStudent(HomestayStudent homestayStudent)
        {
            var isAdd = homestayStudent.HomestayStudentId == 0;

            try
            {
                if (ModelState.IsValid)
                {
                    if (isAdd)
                    {
                        homestayStudent.CreatedUserId = UserId;
                        _context.HomestayStudents.Add(homestayStudent);
                    }
                    else
                    {
                        var updateHomestayStudent =
                            _context.HomestayStudents
                                .Include(x => x.Student)
                                .Include(x => x.Homestay)
                                .FirstOrDefault(x => x.HomestayStudentId == homestayStudent.HomestayStudentId);

                        updateHomestayStudent.Arrival = homestayStudent.Arrival;
                        updateHomestayStudent.Departure = homestayStudent.Departure;
                        updateHomestayStudent.StudentId = homestayStudent.StudentId;
                        updateHomestayStudent.HomestayId = homestayStudent.HomestayId;

                        updateHomestayStudent.DueDate = homestayStudent.DueDate;
                        updateHomestayStudent.Amount = homestayStudent.Amount;

                        if (PermissionId != (int)ConstValue.PermissionType.User)
                        {
                            if (homestayStudent.PaidDate != null)
                                updateHomestayStudent.PaidDate = homestayStudent.PaidDate;
                            updateHomestayStudent.PaidAmount = homestayStudent.PaidAmount;
                        }

                        if (homestayStudent.Remark != null)
                            updateHomestayStudent.Remark = homestayStudent.Remark;

                        updateHomestayStudent.IsActive = homestayStudent.IsActive;
                        updateHomestayStudent.SiteLocationId = homestayStudent.SiteLocationId;
                        updateHomestayStudent.UpdatedUserId = UserId;
                        updateHomestayStudent.UpdatedDate = DateTime.Now;
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

            ViewData["PermissionId"] = PermissionId;

            return PartialView("HomestayStudentDetail", homestayStudent);
        }

        public IActionResult GetStudents(int siteLocationId, string studentName)
        {
            var studentQueryable =
                  _context.Students
                      .Where(x => x.SiteLocationId == siteLocationId && x.IsActive);

            if (!string.IsNullOrEmpty(studentName))
                studentQueryable = studentQueryable.Where(x => x.FirstName.Contains(studentName) || x.LastName.Contains(studentName));

            var students = studentQueryable
                .AsNoTracking()
                .Select(x => new
                {
                    StudentName = ConstValue.GetStudentName(x),
                    StudentId = x.StudentId,
                    StudentNo = x.StudentNo.ToString()
                }).ToList();

            return Json(students);
        }

        public IActionResult GetHomestays()
        {
            var homestays =
                _context.Homestays
                    .Where(x => x.IsActive)
                    .AsNoTracking()
                    .Select(x => new
                    {
                        HomestayFamily = ConstValue.GetHomestayFamilyName(x),
                        HomestayId = x.HomestayId,
                        Address = x.Address
                    }).ToList();

            return Json(homestays);
        }
    }
}
