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

        public async Task<List<Barrels>> GetBarrels()
        {
            return await this.BarrelsRepo.GetBarrels();

        }
        public async Task<Barrels> GetBarrel(Guid id)
        {
            return await this.BarrelsRepo.GetBarrel(id);
        }
        public async Task<Barrels> Create(Barrels barrel)
        {
            return await this.BarrelsRepo.Create(barrel);

        }
        public async Task<Barrels> Delete(Barrels model)
        {
            return await BarrelsRepo.Delete(model);
        }
        public async Task<Barrels> Update(Barrels model)
        {
            return await BarrelsRepo.Update(model);

        }
    }
}
