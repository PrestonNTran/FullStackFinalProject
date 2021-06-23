using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Controllers
{
    public class BarrelsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Details(Guid id) 
        {
            Barrels thing = await BarrelsService.GetBarrel(id);
            BarrelsRegisterViewModel barrel = new BarrelsRegisterViewModel()
            {


            };
            return View(thing);
        }

    }
}
