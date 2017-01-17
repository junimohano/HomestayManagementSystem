using System;
using System.Collections.Generic;
using System.Linq;
using HomestayManagementSystem.Utils;
using Microsoft.AspNetCore.Mvc;

namespace HomestayManagementSystem.Controllers
{
    public class BaseController : Controller
    {
        public int UserId => HttpContext == null ? 0 : Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ConstValue.UserIdKey)?.Value);
        public int PermissionId => HttpContext == null ? 0 : Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ConstValue.PermissionIdKey)?.Value);
        public IEnumerable<int> SiteLocations => HttpContext == null ? new List<int>() : HttpContext.User.Claims.Where(x => x.Type == ConstValue.SiteLocationsKey).Select(x1 => Convert.ToInt32(x1.Value));

        public void SetProfile()
        {
            ViewData["Profile"] = $"Hello, {HttpContext?.User.Claims.FirstOrDefault(x => x.Type == ConstValue.UserInfoKey).Value}";

            //var permissionName = HttpContext.Session.GetString(ConstValue.PermissionNameSessionKey);
            //SiteLocations = siteLocations == null ? new List<int>() : JsonConvert.DeserializeObject<List<int>>(siteLocations);
        }
    }
}
