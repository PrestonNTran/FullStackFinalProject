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

        private IBarrelsService barrelservice;
        

        public BarrelsController(IBarrelsService barrelService) {
            this.barrelservice = barrelService;
        }
        public async Task<IActionResult> Details(Guid id)
        {
            Barrels thing = await barrelservice.GetBarrel(id);
            BarrelsExtraViewModel barrel = new BarrelsExtraViewModel()
            {
                Id = thing.Id,
                Contents = thing.Contents,
                Radius = thing.Radius,
                Material = thing.Material,
                Height = thing.Height,
                Location = thing.Location,
                Weight = thing.Weight,


            };
            return View(barrel);

        }
}
