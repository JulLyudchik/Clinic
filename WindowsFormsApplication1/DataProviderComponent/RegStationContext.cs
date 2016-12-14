using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntitiesComponent;

namespace DataProviderComponent
{
    public class RegStationContext : DbContext
    {
         public RegStationContext()
            : base("DefaultConnection")
        { }

        public DbSet<RegStation> regStations { get; set; }
    }
}
