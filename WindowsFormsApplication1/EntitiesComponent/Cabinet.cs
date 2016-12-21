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
        public Doctor doctor { get; set; }
        public List<CabinetPlan> cabinetPlans{ get; set; }     
    }
}
