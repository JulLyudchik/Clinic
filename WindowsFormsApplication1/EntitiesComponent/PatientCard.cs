using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PatientCard:Entity
    {
        public string name { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime birthDate { get; set; }
        public string sex { get; set; }
        public Street street { get; set; }
        public string houseApartment { get; set; }
        public RegStation registrationStation { get; set; }
        public List<Visit> visits { get; set; }
    }
}
