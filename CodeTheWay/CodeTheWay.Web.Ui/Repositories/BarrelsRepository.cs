using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeTheWay.Web.Ui.Repositories
{
    public class BarrelsRepository : IBarrelsRepository
    {
        private AppDbContext AppDbContext;


        public BarrelsRepository(AppDbContext dbContext)
        {
            this.AppDbContext = dbContext;
        }

        public async Task<Barrels> Create(Barrels barrels)
        {
            var result = await this.AppDbContext.AddAsync(barrels);
            await this.AppDbContext.SaveChangesAsync();

            return result.Entity;

        }
        public async Task<Barrels> Delete(Barrels model)
        {
            AppDbContext.Barrels.Remove(model);
            await AppDbContext.SaveChangesAsync();
            return model;
        }

        public async Task<Barrels> GetBarrel(Guid id)
        {
            return await AppDbContext.Barrels.FirstOrDefaultAsync(i => i.Id == id);

        }
        public async Task<List<Barrels>> GetBarrels()
        {
            return await this.AppDbContext.Barrels.ToListAsync();

        }
        public async Task<Barrels> Update(Barrels model)
        {
            var result = AppDbContext.Barrels.Update(model);
            await AppDbContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}
