using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntitiesComponent;

namespace DataProviderComponent
{
    public class DiagnosisContext : DbContext
    {
        public DiagnosisContext()
            : base("DefaultConnection")
        { }

        public DbSet<Diagnosis> diagnoses { get; set; }
    }
}
