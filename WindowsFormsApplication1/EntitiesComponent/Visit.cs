using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Visit:Entity
    {
        public DateTime date { get; set; }
        public Specialization speciazation { get; set; }
        public Doctor doctor { get; set; }
        public List<Drug> drugs { get; set; }
        public List<Diagnosis> diagnoses { get; set; }
    }
}
