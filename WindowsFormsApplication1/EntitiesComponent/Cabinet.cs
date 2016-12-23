using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cabinet:Entity
    {
        public string number { get; set; }
        public List<Doctor> doctors { get; set; }
        public CabinetPlan cabinetPlan { get; set; }     
    }
}
