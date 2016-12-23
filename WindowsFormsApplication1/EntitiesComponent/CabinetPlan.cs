using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CabinetPlan : Entity
    {        
        public Doctor firstShift_mon { get; set; }
        public Doctor firstShift_tues { get; set; }
        public Doctor firstShift_wednes { get; set; }
        public Doctor firstShift_thurs { get; set; }
        public Doctor firstShift_fri { get; set; }
        public Doctor firstShift_satur { get; set; }
        public Doctor firstShift_sun { get; set; }
        public Doctor secondShift_mon { get; set; }
        public Doctor secondShift_tues { get; set; }
        public Doctor secondShift_wednes { get; set; }
        public Doctor secondShift_thurs { get; set; }
        public Doctor secondShift_fri { get; set; }
        public Doctor secondShift_satur { get; set; }
        public Doctor secondShift_sun { get; set; }

    }
}
