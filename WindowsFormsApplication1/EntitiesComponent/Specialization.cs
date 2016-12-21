using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Specialization : Entity
    {
        public string name { get; set; }
        public string time { get; set; }
        public List<Cabinet> cabinets { get; set; }
        public List<Doctor> doctors { get; set; }
    }
}
