using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CodeTheWay.Web.Ui.Models;

namespace CodeTheWay.Web.Ui.Repositories
{
    interface IBarrelsRepository
    {
        public Task<Barrels> Update(Barrels model);
    }
}
