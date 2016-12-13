using EntitiesComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApplication1
{
    class DiagnosisContext : DbContext
    {
        public DiagnosisContext() 
        :base("DefaultConnection")
    { }
 
    public DbSet<Diagnosis> Diagnoses { get; set; }
    }
}
