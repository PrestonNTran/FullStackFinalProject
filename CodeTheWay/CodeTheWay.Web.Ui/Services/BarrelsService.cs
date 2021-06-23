using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Services
{
    public class BarrelsService : IBarrelsService
    {
        private IBarrelsRepository BarrelsRepo;

        public BarrelsService(AppDbContext dbContext)
        {
            this.BarrelsRepo = new BarrelsRepository(dbContext);
        }
    }
}
