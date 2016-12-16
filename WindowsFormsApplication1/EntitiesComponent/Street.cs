using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesComponent
{
    public class Street
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? RegStationId { get; set; }
        public RegStation regStation { get; set; }
    }
}
