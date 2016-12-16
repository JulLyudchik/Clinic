﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesComponent
{
    public class RegStation
    {
        public int id { get; set; }
        public string name { get; set; }
        public string therapist { get; set; }       
        public ICollection<Street> streets { get; set; }   
        public RegStation()      
        { 
            streets=new List<Street>();
        }
    }
}
