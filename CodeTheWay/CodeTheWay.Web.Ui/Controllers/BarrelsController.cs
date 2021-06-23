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
        

    }
}
