using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HomestayManagementSystem.Database;
using HomestayManagementSystem.Utils;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace HomestayManagementSystem.Controllers
{
    public class CommonController : BaseController
    {
        private readonly HomestayContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        //private const int MaxDimension = 1000;
        //private static string[] AllowedMimeTypes = new[] { "image/jpeg", "image/png", "image/gif" };

        public CommonController(HomestayContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        public IActionResult SaveExcelExport(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }

        public IActionResult GetPermissions()
        {
            var permissions =
                _context.Permissions
                    //.Where(x => x.PermissionId >= PermissionId)
                    .AsNoTracking()
                    .ToList();

            return Json(permissions);
        }

        public IActionResult GetSites()
        {
            var sites =
                _context.Sites
                    .Where(x => x.SiteLocations.Select(x1 => x1.SiteLocationId).Intersect(SiteLocations).Any())
                    .AsNoTracking()
                    .ToList();

            return Json(sites);
        }

        public IActionResult GetSiteLocations(int siteId)
        {
            var siteLocations =
                _context.SiteLocations
                    .Where(x => x.SiteId == siteId && SiteLocations.Contains(x.SiteLocationId))
                    .AsNoTracking()
                    .ToList();

            return Json(siteLocations);
        }

        public async Task<IActionResult> SaveFile(IEnumerable<IFormFile> files, ConstValue.FileType fileType, int id, string previousFileName)
        {
            // The Name of the Upload component is "files"
            if (files != null)
            {
                foreach (var file in files)
                {
                    var fileContent = ContentDispositionHeaderValue.Parse(file.ContentDisposition);

                    // Some browsers send file names with full path.
                    // We are only interested in the file name.
                    var fileName = Path.GetFileName(id + "_" + fileContent.FileName.Trim('"'));

                    if (previousFileName != null)
                    {
                        var previousFilePath = Path.Combine(_hostingEnvironment.WebRootPath, ConstValue.GetFileLocation(fileType), previousFileName);
                        if (System.IO.File.Exists(previousFilePath))
                            System.IO.File.Delete(previousFilePath);
                    }

                    var physicalPath = Path.Combine(_hostingEnvironment.WebRootPath, ConstValue.GetFileLocation(fileType), fileName);

                    using (var fileStream = new FileStream(physicalPath, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }
            }

            // Return an empty string to signify success
            return Content(string.Empty);
        }

        public IActionResult RemoveFile(string[] fileNames, ConstValue.FileType fileType)
        {
            // The parameter of the Remove action must be called "fileNames"
            if (fileNames != null)
            {
                foreach (var fullName in fileNames)
                {
                    var fileName = Path.GetFileName(fullName);
                    var physicalPath = Path.Combine(_hostingEnvironment.WebRootPath, ConstValue.GetFileLocation(fileType), fileName);

                    if (System.IO.File.Exists(physicalPath))
                        System.IO.File.Delete(physicalPath);
                }
            }

            // Return an empty string to signify success
            return Content(string.Empty);
        }

        public FileResult DownloadFile(ConstValue.FileType fileType, int id)
        {
            var fileName = string.Empty;
            switch (fileType)
            {
                case ConstValue.FileType.HomestayContract:
                    fileName = _context.HomestayContracts.FirstOrDefault(x => x.HomestayContractId == id)?.ContractFileName;
                    break;

                case ConstValue.FileType.HomestayEvaluation:
                    fileName = _context.HomestayEvaluations.FirstOrDefault(x => x.HomestayEvaluationId == id)?.EvaluationFileName;
                    break;

                case ConstValue.FileType.HomestayPoliceCheck:
                    fileName = _context.HomestayPoliceChecks.FirstOrDefault(x => x.HomestayPoliceCheckId == id)?.PoliceCheckFileName;
                    break;

                case ConstValue.FileType.HomestayProfile:
                    fileName = _context.Homestays.FirstOrDefault(x => x.HomestayId == id)?.ProfileFileName;
                    break;

                case ConstValue.FileType.StudentProfile:
                    fileName = _context.Students.FirstOrDefault(x => x.StudentId == id)?.ProfileFileName;
                    break;
            }
            var physicalPath = Path.Combine(_hostingEnvironment.WebRootPath, ConstValue.GetFileLocation(fileType), fileName);
            var fileBytes = System.IO.File.ReadAllBytes(physicalPath);

            return File(fileBytes, "application/x-msdownload", fileName);
        }

        //[Route("resize/{*imagePath}")]
        //public async Task<IActionResult> Index(string imagePath, int width, int height)
        //{

        //    //// Validate incoming params
        //    //if (maxWidth < 0 || maxHeight < 0 || maxWidth > MaxDimension || maxHeight > MaxDimension
        //    //    || (maxWidth + maxHeight) == 0)
        //    //{
        //    //    return BadRequest("Invalid dimensions");
        //    //}

        //    var mimeType = GetContentType(imagePath);
        //    if (Array.IndexOf(AllowedMimeTypes, mimeType) < 0)
        //    {
        //        return BadRequest("Disallowed image format");
        //    }

        //    // Locate source image on disk
        //    var fileInfo = _hostingEnvironment.WebRootFileProvider.GetFileInfo(imagePath);
        //    if (!fileInfo.Exists)
        //    {
        //        return NotFound();
        //    }

        //    using (var stream = System.IO.File.OpenRead(fileInfo.PhysicalPath))
        //    {
        //        try
        //        {
        //            var output = System.IO.File.OpenWrite("abc.jpg");
        //            var image = new Image(stream);
        //            image.Resize(image.Width / 2, image.Height / 2)
        //                 .Save(output);

        //            return File(stream, mimeType);
        //        }
        //        catch (Exception ex)
        //        {
        //            var aa = "";
        //        }

        //    }

        //    return null;

        //    //var imageStream = await _nodeServices.InvokeAsync<Stream>(
        //    //    "./Node/resizeImage",
        //    //    fileInfo.PhysicalPath,
        //    //    mimeType,
        //    //    maxWidth,
        //    //    maxHeight);

        //}

        //private string GetContentType(string path)
        //{
        //    string result;
        //    return new FileExtensionContentTypeProvider().TryGetContentType(path, out result) ? result : null;
        //}

    }
}
