using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessManager.DataLeyer;
using BusinessManager.DomainClasses;
using BusinessManager.Services.Repositories;
using BusinessManager.ViewModels;

namespace BusinessManager.Web.Areas.Admin.Controllers
{
    [Route("Moshtaris")]
    public class MoshtarisController : Controller
    {

        private readonly IMoshtari _MoshtariRepository;
        private readonly IHesabMoshtari _HesabMoshtariRepository;

        public MoshtarisController(IMoshtari MoshtariService,
            IHesabMoshtari HesabMoshtariRepository
            )
        {
            _MoshtariRepository = MoshtariService;
            _HesabMoshtariRepository = HesabMoshtariRepository;
        }

        // GET: Admin/Moshtaris
        [Route("Index")]
        [Route("~/")]
        public async Task<IActionResult> Index()
        {
            var model = await _MoshtariRepository.GetAllMoshtarisAsync();
            return View(model);
        }

        // GET: Admin/Moshtaris/Details/5
        [Route("Details/id")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moshtari = await _MoshtariRepository.GetMoshtariByIdAsync(id.Value);
            if (moshtari == null)
            {
                return NotFound();
            }

            return View(moshtari);
        }

        // POST: Admin/Moshtaris/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[ValidateAntiForgeryToken]
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([Bind("Id,Radif,Nam,Family")]AddMoshtariViewModel ViewModel)
        {
            if (ViewModel.Id.HasValue)
            {
                var moshtari = await _MoshtariRepository.GetMoshtariByIdAsync(ViewModel.Id.Value);
                if (moshtari == null)
                {
                    return Json(new { Success = "false", Error = "مشتری وجود ندارد", Result = "" });
                }
                moshtari.Nam = ViewModel.Nam;
                moshtari.Family = ViewModel.Family;
                moshtari.Radif = ViewModel.Radif;

                try
                {
                    _MoshtariRepository.updateMoshtari(moshtari);
                    _MoshtariRepository.save();

                    return Json(new { Success = "true", Error = "", Result = "" });
                }
                catch (Exception ex)
                {
                    return Json(new { Success = "false", Error = ex.Message, Result = "" });
                }
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    string errors = "";
                    foreach (var item in ModelState.Values.SelectMany(m => m.Errors).Select(e => e.ErrorMessage))
                    {
                        errors += item + "\n";
                    }

                    return Json(new { Success = "false", Error = errors, Result = "" });
                }

                Moshtari moshtari = new Moshtari
                {
                    Radif = ViewModel.Radif,
                    Nam = ViewModel.Nam,
                    Family = ViewModel.Family,
                };
                try
                {
                    _MoshtariRepository.InsertMoshtari(moshtari);
                    _MoshtariRepository.save();

                    return Json(new { Success = "true", Error = "", Result = "" });
                }
                catch (Exception ex)
                {
                    return Json(new { Success = "false", Error = ex.Message, Result = "" });
                }
            }
        }

        // POST: Admin/Moshtaris/Delete/5
        [HttpPost]
        [Route("Delete/id")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var moshtari = await _MoshtariRepository.GetMoshtariByIdAsync(id);
            if (moshtari == null)
            {
                return Json(new { Success = "false", Error = "مشتری وجود ندارد", Result = "" });
            }
            try
            {
                _MoshtariRepository.DeleteMoshtari(moshtari);
                _MoshtariRepository.save();

                return Json(new { Success = "true", Error = "", Result = "" });
            }
            catch (Exception ex)
            {
                return Json(new { Success = "false", Error = ex.Message, Result = "" });
            }

        }

        [Route("Search")]
        public async Task<IActionResult> Search(string name, string family, int number)
        {

            var result = ViewComponent("SearchResultMoshtari", new AddMoshtariViewModel { Nam = name, Family = family, Radif = number });
            return result;
        }

        [Route("HesabMoshtari/{moshtariId:int}")]
        public async Task<IActionResult> HesabMoshtari(int moshtariId)
        {
            ViewData["Moshtari"] = await _MoshtariRepository.GetMoshtariByIdAsync(moshtariId);
            var hesabMoshtari = await _HesabMoshtariRepository.GetHesabMoshtariByMoshtariIdAsync(moshtariId);
            return View(hesabMoshtari);
        }

        // POST: Admin/Moshtaris/Delete/5
        [HttpPost]
        [Route("DeleteHesab/id")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteHesab(int id)
        {
            var HesabMoshtari = await _HesabMoshtariRepository.GetHesabMoshtariByIdAsync(id);
            if (HesabMoshtari == null)
            {
                return Json(new { Success = "false", Error = "خطا در فراخوانی اطلاعات", Result = "" });
            }
            try
            {
                _HesabMoshtariRepository.DeleteHesabMoshtari(HesabMoshtari);
                _HesabMoshtariRepository.Save();

                return Json(new { Success = "true", Error = "", Result = "" });
            }
            catch (Exception ex)
            {
                return Json(new { Success = "false", Error = ex.Message, Result = "" });
            }

        }

        [HttpPost]
        [Route("AddHesab")]
        public IActionResult AddHesab(HesabMoshtari hesabMoshtari)
        {
            if (!ModelState.IsValid)
            {
                string errors = "";
                foreach (var item in ModelState.Values.SelectMany(m => m.Errors).Select(e => e.ErrorMessage))
                {
                    errors += item + "\n";
                }

                return Json(new { Success = "false", Error = errors, Result = "" });
            }
            try
            {
                _HesabMoshtariRepository.InsertHesabMoshtari(hesabMoshtari);
                _HesabMoshtariRepository.Save();

                return Json(new { Success = "true", Error = "", Result = "" });
            }
            catch (Exception ex)
            {
                return Json(new { Success = "false", Error = ex.Message, Result = "" });
            }
        }
    }
}
