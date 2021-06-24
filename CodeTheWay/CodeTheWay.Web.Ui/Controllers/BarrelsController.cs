using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models.NewViewModels;

namespace CodeTheWay.Web.Ui.Controllers
{
    public class BarrelsController : Controller
    {
        private IBarrelsService BarrelsService;
        public BarrelsController(IBarrelsService barrelsservice)
        {
            this.BarrelsService = barrelsservice;
        }
        public async Task<IActionResult> Index()
        {
            return View(await BarrelsService.GetBarrels());
        }
        public async Task<IActionResult> Create()
        {
            return View(new BarrelsExtraViewModel());
        }

        public async Task<IActionResult> Details(Guid id) 
        {
            Barrels thing = await BarrelsService.GetBarrel(id);
            BarrelsExtraViewModel barrel = new BarrelsExtraViewModel();
            return View(thing);
        }
        [HttpPost]
        public async Task<IActionResult> Update(BarrelsExtraViewModel model)
        {
            if (ModelState.IsValid)
            {
                Barrels barrels = new Barrels
                {
                    Id = model.Id,
                    Weight = model.Weight,
                    Radius = model.Radius,
                    Height = model.Height,
                    Contents = model.Contents,
                    Location = model.Location,
                    Material = model.Material,
                };
                Barrels barrels2 = await BarrelsService.Update(barrels);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public async Task<IActionResult> Edit(Guid id)
        {

            var model = await BarrelsService.GetBarrel(id);
            BarrelsExtraViewModel ship = new BarrelsExtraViewModel()
            {
                Id = model.Id,
                Weight = model.Weight,
                Radius = model.Radius,
                Height = model.Height,
                Contents = model.Contents,
                Location = model.Location,
                Material = model.Material,
            };
            return View(ship);
        }


    }
}
