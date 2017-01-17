using System;
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
    public class HomestayController : BaseController
    {
        private readonly HomestayContext _context;

        public HomestayController(HomestayContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult List()
        {
            SetProfile();
            return View("HomestayList");
        }

        public IActionResult HomestayDetailPartial(int homestayId)
        {
            Homestay homestay;
            if (homestayId == 0)
                homestay = new Homestay();
            else
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.HomestayId == homestayId);
                ViewData["SelectedVideoUrl"] = homestay.VideoUrl;
            }
            return PartialView("HomestayDetail", homestay);
        }

        public IActionResult HomestayHouseHoldDetailPartial(int homestayId, int homestayHouseHoldId)
        {
            HomestayHouseHold homestayHouseHold;
            if (homestayHouseHoldId == 0)
            {
                homestayHouseHold = new HomestayHouseHold();
                homestayHouseHold.HomestayId = homestayId;
            }
            else
            {
                homestayHouseHold = _context.HomestayHouseHolds.Include(x => x.Homestay)
                    .FirstOrDefault(x => x.HomestayHouseHoldId == homestayHouseHoldId);
            }
            return PartialView("HomestayHouseHoldDetail", homestayHouseHold);
        }

        public IActionResult HomestayContractDetailPartial(int homestayId, int homestayContractId)
        {
            HomestayContract homestayContract;
            if (homestayContractId == 0)
            {
                homestayContract = new HomestayContract();
                homestayContract.HomestayId = homestayId;
            }
            else
            {
                homestayContract = _context.HomestayContracts.Include(x => x.Homestay)
                    .FirstOrDefault(x => x.HomestayContractId == homestayContractId);
            }
            return PartialView("HomestayContractDetail", homestayContract);
        }

        public IActionResult HomestayEvaluationDetailPartial(int homestayId, int homestayEvaluationId)
        {
            HomestayEvaluation homestayEvaluation;
            if (homestayEvaluationId == 0)
            {
                homestayEvaluation = new HomestayEvaluation();
                homestayEvaluation.HomestayId = homestayId;
            }
            else
            {
                homestayEvaluation = _context.HomestayEvaluations.Include(x => x.Homestay)
                    .FirstOrDefault(x => x.HomestayEvaluationId == homestayEvaluationId);
            }

            return PartialView("HomestayEvaluationDetail", homestayEvaluation);
        }

        public IActionResult HomestayPoliceCheckDetailPartial(int homestayId, int homestayPoliceCheckId)
        {
            HomestayPoliceCheck homestayPoliceCheck;
            if (homestayPoliceCheckId == 0)
            {
                homestayPoliceCheck = new HomestayPoliceCheck { HomestayId = homestayId };
            }
            else
            {
                homestayPoliceCheck = _context.HomestayPoliceChecks.Include(x => x.Homestay)
                    .FirstOrDefault(x => x.HomestayPoliceCheckId == homestayPoliceCheckId);
            }
            return PartialView("HomestayPoliceCheckDetail", homestayPoliceCheck);
        }

        public IActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            var homestays =
                _context.Homestays
                    .Include(x => x.CreatedUser)
                    .Include(x => x.UpdatedUser)
                    .Include(x => x.HomestayEvaluations)
                    .Include(x => x.HomestayContracts)
                    .Include(x => x.HomestayPoliceChecks)
                    .Include(x => x.HomestayHouseHolds)
                    .AsNoTracking()
                    .Select(x => new Homestay()
                    {
                        HomestayId = x.HomestayId,
                        HomestayFamily = ConstValue.GetHomestayFamilyName(x),
                        Address = x.Address,
                        Score = x.HomestayEvaluations.Any(x1 => x1.IsEvaluationActive) ? x.HomestayEvaluations.LastOrDefault(x1 => x1.IsEvaluationActive).GetScore() : 0,
                        Contract = x.HomestayContracts.Any(x1 => x1.IsContractActive) ? x.HomestayContracts.LastOrDefault(x1 => x1.IsContractActive).ContractDate : null,
                        Students = x.Students,
                        HouseHolders = x.HomestayHouseHolds.Count(x1 => x1.IsHouseHoldActive),
                        PoliceCheck = x.HomestayPoliceChecks.Any(x1 => x1.IsPoliceCheckActive) ? x.HomestayPoliceChecks.LastOrDefault(x1 => x1.IsPoliceCheckActive).PoliceCheckDate : null,
                        Language = x.Language,
                        Room = x.Room,
                        IsActive = x.IsActive,
                        CreatedDate = x.CreatedDate,
                        CreatedUserName = ConstValue.GetUserName(x.CreatedUser),
                        UpdatedDate = x.UpdatedDate,
                        UpdatedUserName = ConstValue.GetUserName(x.UpdatedUser)
                    })
                    .OrderByDescending(x => x.HomestayId);

            return Json(homestays.ToDataSourceResult(request));
        }

        public IActionResult ReadHomestayHouseHold([DataSourceRequest] DataSourceRequest request, int homestayId)
        {
            var homestayHouseHolds =
                _context.HomestayHouseHolds
                    .Where(x => x.HomestayId == homestayId)
                    .AsNoTracking()
                    .Select(x => new HomestayHouseHold()
                    {
                        HomestayHouseHoldId = x.HomestayHouseHoldId,
                        HomestayId = x.HomestayId,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Gender = x.Gender,
                        Birthday = x.Birthday,
                        IsHouseHoldActive = x.IsHouseHoldActive,
                        CreatedDate = x.CreatedDate,
                        CreatedUserName = ConstValue.GetUserName(x.CreatedUser),
                        UpdatedDate = x.UpdatedDate,
                        UpdatedUserName = ConstValue.GetUserName(x.UpdatedUser)
                    })
                    .OrderByDescending(x => x.HomestayHouseHoldId);

            return Json(homestayHouseHolds.ToDataSourceResult(request));
        }

        public IActionResult ReadHomestayContract([DataSourceRequest] DataSourceRequest request, int homestayId)
        {
            var homestayContracts =
                _context.HomestayContracts
                    .Where(x => x.HomestayId == homestayId)
                    .AsNoTracking()
                    .Select(x => new HomestayContract()
                    {
                        HomestayContractId = x.HomestayContractId,
                        HomestayId = x.HomestayId,
                        ContractDate = x.ContractDate,
                        ContractFileName = x.ContractFileName,
                        IsContractActive = x.IsContractActive,
                        CreatedDate = x.CreatedDate,
                        CreatedUserName = ConstValue.GetUserName(x.CreatedUser),
                        UpdatedDate = x.UpdatedDate,
                        UpdatedUserName = ConstValue.GetUserName(x.UpdatedUser)
                    })
                    .OrderByDescending(x => x.HomestayContractId);

            return Json(homestayContracts.ToDataSourceResult(request));
        }

        public IActionResult ReadHomestayEvaluation([DataSourceRequest] DataSourceRequest request, int homestayId)
        {
            var homestayEvaluations =
                _context.HomestayEvaluations
                    .Where(x => x.HomestayId == homestayId)
                    .AsNoTracking()
                    .Select(x => new HomestayEvaluation()
                    {
                        HomestayEvaluationId = x.HomestayEvaluationId,
                        HomestayId = x.HomestayId,
                        EvaluationDate = x.EvaluationDate,
                        EvaluationFileName = x.EvaluationFileName,
                        Score = x.Location + x.EnglishProficiency + x.CriminalRecordCheck + x.LivingSpace + x.QualityOfLivingSpace + x.FinancialStability + x.HostingExperience + x.PaymentFlexibility,
                        IsEvaluationActive = x.IsEvaluationActive,
                        CreatedDate = x.CreatedDate,
                        CreatedUserName = ConstValue.GetUserName(x.CreatedUser),
                        UpdatedDate = x.UpdatedDate,
                        UpdatedUserName = ConstValue.GetUserName(x.UpdatedUser)
                    })
                    .OrderByDescending(x => x.HomestayEvaluationId);

            return Json(homestayEvaluations.ToDataSourceResult(request));
        }

        public IActionResult ReadHomestayPoliceCheck([DataSourceRequest] DataSourceRequest request, int homestayId)
        {
            var homestayPoliceChecks =
                _context.HomestayPoliceChecks
                    .Where(x => x.HomestayId == homestayId)
                    .AsNoTracking()
                    .Select(x => new HomestayPoliceCheck()
                    {
                        HomestayPoliceCheckId = x.HomestayPoliceCheckId,
                        HomestayId = x.HomestayId,
                        PoliceCheckDate = x.PoliceCheckDate,
                        PoliceCheckFileName = x.PoliceCheckFileName,
                        Remark = x.Remark,
                        IsPoliceCheckActive = x.IsPoliceCheckActive,
                        CreatedDate = x.CreatedDate,
                        CreatedUserName = ConstValue.GetUserName(x.CreatedUser),
                        UpdatedDate = x.UpdatedDate,
                        UpdatedUserName = ConstValue.GetUserName(x.UpdatedUser)
                    })
                    .OrderByDescending(x => x.HomestayPoliceCheckId);

            return Json(homestayPoliceChecks.ToDataSourceResult(request));
        }

        [HttpPost]
        public IActionResult SetHomestay(Homestay homestay)
        {
            var isAdd = homestay.HomestayId == 0;

            try
            {

                if (ModelState.IsValid)
                {
                    if (isAdd)
                    {
                        homestay.CreatedUserId = UserId;
                        _context.Homestays.Add(homestay);
                    }
                    else
                    {
                        var updateHomestay = _context.Homestays.FirstOrDefault(x => x.HomestayId == homestay.HomestayId);
                        updateHomestay.FirstName = homestay.FirstName;
                        updateHomestay.LastName = homestay.LastName;
                        updateHomestay.Address = homestay.Address;
                        updateHomestay.PostCode = homestay.PostCode;
                        updateHomestay.Phone = homestay.Phone;
                        updateHomestay.Room = homestay.Room;
                        if (homestay.Language != null)
                            updateHomestay.Language = homestay.Language;
                        if (homestay.Students != null)
                            updateHomestay.Students = homestay.Students;
                        if (homestay.Email != null)
                            updateHomestay.Email = homestay.Email;
                        updateHomestay.IsActive = homestay.IsActive;
                        if (homestay.VideoUrl != null)
                            updateHomestay.VideoUrl = homestay.VideoUrl;
                        if (homestay.ProfileFileName != null)
                            updateHomestay.ProfileFileName = homestay.ProfileFileName;
                        if (homestay.Remark != null)
                            updateHomestay.Remark = homestay.Remark;
                        updateHomestay.IsActive = homestay.IsActive;

                        updateHomestay.UpdatedUserId = UserId;
                        updateHomestay.UpdatedDate = DateTime.Now;
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

            return PartialView("HomestayDetail", homestay);
        }

        //private IEnumerable<string> GetFileInfo(IEnumerable<IFormFile> files)
        //{
        //    List<string> fileInfo = new List<string>();

        //    foreach (var file in files)
        //    {
        //        var fileContent = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
        //        var fileName = Path.GetFileName(fileContent.FileName.Trim('"'));

        //        fileInfo.Add(string.Format("{0} ({1} bytes)", fileName, file.Length));
        //    }

        //    return fileInfo;
        //}

        [HttpPost]
        public IActionResult SetHomestayHouseHold(HomestayHouseHold homestayHouseHold)
        {
            var isAdd = homestayHouseHold.HomestayHouseHoldId == 0;

            try
            {
                if (ModelState.IsValid)
                {
                    if (isAdd)
                    {
                        homestayHouseHold.CreatedUserId = UserId;
                        _context.HomestayHouseHolds.Add(homestayHouseHold);
                    }
                    else
                    {
                        var updateHomestayHouseHold = _context.HomestayHouseHolds.Include(x => x.Homestay).FirstOrDefault(x => x.HomestayHouseHoldId == homestayHouseHold.HomestayHouseHoldId);
                        updateHomestayHouseHold.FirstName = homestayHouseHold.FirstName;
                        updateHomestayHouseHold.LastName = homestayHouseHold.LastName;
                        updateHomestayHouseHold.Gender = homestayHouseHold.Gender;
                        updateHomestayHouseHold.Birthday = homestayHouseHold.Birthday;
                        if (homestayHouseHold.Remark != null)
                            updateHomestayHouseHold.Remark = homestayHouseHold.Remark;
                        updateHomestayHouseHold.IsHouseHoldActive = homestayHouseHold.IsHouseHoldActive;

                        updateHomestayHouseHold.UpdatedUserId = UserId;
                        updateHomestayHouseHold.UpdatedDate = DateTime.Now;
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

            return PartialView("HomestayHouseHoldDetail", homestayHouseHold);
        }

        [HttpPost]
        public IActionResult SetHomestayContract(HomestayContract homestayContract)
        {
            var isAdd = homestayContract.HomestayContractId == 0;

            try
            {
                if (ModelState.IsValid)
                {
                    if (isAdd)
                    {
                        homestayContract.CreatedUserId = UserId;
                        _context.HomestayContracts.Add(homestayContract);
                    }
                    else
                    {
                        var updateHomestayContract = _context.HomestayContracts.Include(x => x.Homestay).FirstOrDefault(x => x.HomestayContractId == homestayContract.HomestayContractId);
                        updateHomestayContract.ContractDate = homestayContract.ContractDate;
                        if (homestayContract.Remark != null)
                            updateHomestayContract.Remark = homestayContract.Remark;
                        if (homestayContract.ContractFileName != null)
                            updateHomestayContract.ContractFileName = homestayContract.ContractFileName;
                        updateHomestayContract.IsContractActive = homestayContract.IsContractActive;

                        updateHomestayContract.UpdatedUserId = UserId;
                        updateHomestayContract.UpdatedDate = DateTime.Now;
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

            return PartialView("HomestayContractDetail", homestayContract);
        }

        [HttpPost]
        public IActionResult SetHomestayEvaluation(HomestayEvaluation homestayEvaluation)
        {
            var isAdd = homestayEvaluation.HomestayEvaluationId == 0;

            try
            {
                if (ModelState.IsValid)
                {
                    if (isAdd)
                    {
                        homestayEvaluation.CreatedUserId = UserId;
                        _context.HomestayEvaluations.Add(homestayEvaluation);
                    }
                    else
                    {
                        var updateHomestayEvaluation = _context.HomestayEvaluations.Include(x => x.Homestay).FirstOrDefault(x => x.HomestayEvaluationId == homestayEvaluation.HomestayEvaluationId);
                        updateHomestayEvaluation.EvaluationDate = homestayEvaluation.EvaluationDate;
                        if (homestayEvaluation.Remark != null)
                            updateHomestayEvaluation.Remark = homestayEvaluation.Remark;
                        if (homestayEvaluation.EvaluationFileName != null)
                            updateHomestayEvaluation.EvaluationFileName = homestayEvaluation.EvaluationFileName;

                        updateHomestayEvaluation.Location = homestayEvaluation.Location;
                        updateHomestayEvaluation.EnglishProficiency = homestayEvaluation.EnglishProficiency;
                        updateHomestayEvaluation.CriminalRecordCheck = homestayEvaluation.CriminalRecordCheck;
                        updateHomestayEvaluation.LivingSpace = homestayEvaluation.LivingSpace;
                        updateHomestayEvaluation.QualityOfLivingSpace = homestayEvaluation.QualityOfLivingSpace;
                        updateHomestayEvaluation.FinancialStability = homestayEvaluation.FinancialStability;
                        updateHomestayEvaluation.HostingExperience = homestayEvaluation.HostingExperience;
                        updateHomestayEvaluation.PaymentFlexibility = homestayEvaluation.PaymentFlexibility;
                        updateHomestayEvaluation.IsEvaluationActive = homestayEvaluation.IsEvaluationActive;

                        updateHomestayEvaluation.UpdatedUserId = UserId;
                        updateHomestayEvaluation.UpdatedDate = DateTime.Now;
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

            return PartialView("HomestayEvaluationDetail", homestayEvaluation);
        }

        [HttpPost]
        public IActionResult SetHomestayPoliceCheck(HomestayPoliceCheck homestayPoliceCheck)
        {
            var isAdd = homestayPoliceCheck.HomestayPoliceCheckId == 0;

            try
            {
                if (ModelState.IsValid)
                {
                    if (isAdd)
                    {
                        homestayPoliceCheck.CreatedUserId = UserId;
                        _context.HomestayPoliceChecks.Add(homestayPoliceCheck);
                    }
                    else
                    {
                        var updateHomestayPoliceCheck = _context.HomestayPoliceChecks.Include(x => x.Homestay).FirstOrDefault(x => x.HomestayPoliceCheckId == homestayPoliceCheck.HomestayPoliceCheckId);
                        updateHomestayPoliceCheck.PoliceCheckDate = homestayPoliceCheck.PoliceCheckDate;
                        if (homestayPoliceCheck.Remark != null)
                            updateHomestayPoliceCheck.Remark = homestayPoliceCheck.Remark;
                        if (homestayPoliceCheck.PoliceCheckFileName != null)
                            updateHomestayPoliceCheck.PoliceCheckFileName = homestayPoliceCheck.PoliceCheckFileName;
                        updateHomestayPoliceCheck.IsPoliceCheckActive = homestayPoliceCheck.IsPoliceCheckActive;

                        updateHomestayPoliceCheck.UpdatedUserId = UserId;
                        updateHomestayPoliceCheck.UpdatedDate = DateTime.Now;
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

            return PartialView("HomestayPoliceCheckDetail", homestayPoliceCheck);
        }

    }
}

