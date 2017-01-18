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
    public class StudentController : BaseController
    {
        private readonly HomestayContext _context;

        public StudentController(HomestayContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult List()
        {
            SetProfile();
            return View("StudentList");
        }

        public IActionResult StudentDetailPartial(int studentId)
        {
            Student student;
            if (studentId == 0)
                student = new Student();
            else
            {
                student = _context.Students.Include(x => x.SiteLocation).ThenInclude(x1 => x1.Site)
                                        .FirstOrDefault(x => x.StudentId == studentId);
                student.SiteId = student.SiteLocation.SiteId;
            }
            return PartialView("StudentDetail", student);
        }

        public IActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            IEnumerable<Student> students =
                _context.Students
                    .Include(x => x.CreatedUser)
                    .Include(x => x.UpdatedUser)
                    .Include(x => x.SiteLocation)
                    .Where(x => SiteLocations.Contains(x.SiteLocationId))
                    .AsNoTracking()
                    .Select(x => new Student()
                    {
                        StudentId = x.StudentId,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Address = x.Address,
                        Gender = x.Gender,
                        Phone = x.Phone,
                        StudentNo = x.StudentNo,
                        SiteLocation = x.SiteLocation,
                        SiteName = x.SiteLocation.Site.Name,
                        IsActive = x.IsActive,
                        CreatedDate = x.CreatedDate,
                        CreatedUserName = ConstValue.GetUserName(x.CreatedUser),
                        UpdatedDate = x.UpdatedDate,
                        UpdatedUserName = ConstValue.GetUserName(x.UpdatedUser)
                    })
                    .OrderByDescending(x => x.StudentId);

            return Json(students.ToDataSourceResult(request));
        }

        [HttpPost]
        public IActionResult SetStudent(Student student)
        {
            var isAdd = student.StudentId == 0;

            try
            {
                if (ModelState.IsValid)
                {
                    if (isAdd)
                    {
                        student.CreatedUserId = UserId;
                        _context.Students.Add(student);
                    }
                    else
                    {
                        var updateStudent = _context.Students.Include(x => x.SiteLocation).FirstOrDefault(x => x.StudentId == student.StudentId);
                        updateStudent.FirstName = student.FirstName;
                        updateStudent.LastName = student.LastName;
                        updateStudent.Address = student.Address;
                        updateStudent.PostCode = student.PostCode;
                        updateStudent.Phone = student.Phone;
                        updateStudent.Gender = student.Gender;
                        if (student.Email != null)
                            updateStudent.Email = student.Email;
                        if (student.ProfileFileName != null)
                            updateStudent.ProfileFileName = student.ProfileFileName;
                        updateStudent.StudentNo = student.StudentNo;
                        if (student.Remark != null)
                            updateStudent.Remark = student.Remark;
                        updateStudent.IsActive = student.IsActive;
                        updateStudent.SiteLocationId = student.SiteLocationId;
                        updateStudent.UpdatedUserId = UserId;
                        updateStudent.UpdatedDate = DateTime.Now;
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

            return PartialView("StudentDetail", student);
        }

    }
}
