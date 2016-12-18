using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Doctor : Entity
    {
        public string name { get; set; }
        public string specialization { get; set; }
        public string cabinet { get; set; }
        //public string regStation { get; set; }

    }
}
