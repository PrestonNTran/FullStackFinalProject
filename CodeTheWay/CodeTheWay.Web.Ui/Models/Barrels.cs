using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Models
{
    public class Barrels
    {
        public Guid Id { get; set; }
        public double Radius { get; set; }
        public double Height { get; set; }
        public string Contents { get; set; }
        public string Location { get; set; }
        public double Weight { get; set; }
        public string Material { get; set; }

    }
}
