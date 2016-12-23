using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket:Entity
    {
        public DateTime date { get; set; }
        public Doctor doctor { get; set; }
        public Specialization specialization { get; set; }
        public Cabinet cabinet { get; set; }
        public PatientCard patCard { get; set; }   
    }
}
