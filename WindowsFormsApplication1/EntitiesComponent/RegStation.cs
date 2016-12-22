using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Model
{
    public class RegStation : Entity
    {
        public string name { get; set; }              
        public List<Street> streets { get; set; } 
    }
}
