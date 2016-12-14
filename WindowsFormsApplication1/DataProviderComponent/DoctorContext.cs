using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntitiesComponent;

namespace DataProviderComponent
{
    public class DoctorContext : DbContext
    {
        public DoctorContext()
            : base("DefaultConnection")
        { }

        public DbSet<Doctor> doctors { get; set; }
    }
}
