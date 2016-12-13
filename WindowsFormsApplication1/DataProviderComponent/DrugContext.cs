using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntitiesComponent;
namespace DataProviderComponent
{
    public class DrugContext : DbContext
    {
         public DrugContext()
            : base("DefaultConnection")
        { }

        public DbSet<Drug> Drugs { get; set; }
    }
}
