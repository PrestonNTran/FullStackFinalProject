using CodeTheWay.Web.Ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Services
{
    interface IBarrelsService
    {
        public Task<List<Barrels>> GetBarrels();
        public Task<Barrels> GetBarrel(Guid id);
        public Task<Barrels> Create(Barrels barrel);
        public Task<Barrels> Delete(Barrels model);
        public Task<Barrels> Update(Barrels model);
    }
}
