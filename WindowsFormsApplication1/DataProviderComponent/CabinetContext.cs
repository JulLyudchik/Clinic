using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntitiesComponent;

namespace DataProviderComponent
{
    public class CabinetContext : DbContext
    {
        public CabinetContext()
            : base("DefaultConnection")
        { }

        public DbSet<Cabinet> cabinets { get; set; }
        public DbSet<CabinetPlan> cabinetplans { get; set; }
    }
}
