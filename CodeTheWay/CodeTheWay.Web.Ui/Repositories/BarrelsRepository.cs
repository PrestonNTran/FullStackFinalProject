using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CodeTheWay.Web.Ui.Models;

namespace CodeTheWay.Web.Ui.Repositories
{
    public class BarrelsRepository
    {
        private AppDbContext AppDbContext;
        public async Task<Barrels> Update(Barrels model)
        {
            var result = AppDbContext.Barrels.Update(model);
            await AppDbContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}
