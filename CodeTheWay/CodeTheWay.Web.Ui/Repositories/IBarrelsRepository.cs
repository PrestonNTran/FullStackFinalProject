using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models;

using CodeTheWay.Web.Ui.Models;

namespace CodeTheWay.Web.Ui.Repositories
{
    interface IBarrelsRepository
    {
        public Task<List<Barrels>> GetBarrels();
        public Task<Barrels> GetBarrel(Guid id);
        public Task<Barrels> Create(Barrels barrel);
        public Task<Barrels> Delete(Barrels model);        

        public Task<Barrels> Update(Barrels model);
    }
}
