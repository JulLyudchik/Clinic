using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CabinetPlan : Entity
    {
        public string day { get; set; }
        public Doctor firstShift { get; set; }
        public Doctor secondShift { get; set; }
    }
}
