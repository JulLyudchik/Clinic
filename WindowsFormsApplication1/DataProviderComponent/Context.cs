using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace Controller
{
    public class Context : DbContext
    {
        public Context()
            : base("DefaultConnection")
        { }
        public DbSet<Cabinet> cabinets { get; set; }
        public DbSet<CabinetPlan> cabinetplans { get; set; }
        public DbSet<Diagnosis> diagnoses { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Drug> drugs { get; set; }
        public DbSet<RegStation> regStations { get; set; }
        public DbSet<Street> streets { get; set; }
        public DbSet<Specialization> specializations { get; set; }
        public DbSet<PatientCard> patientCards { get; set; }
        public DbSet<Visit> visits { get; set; }
    }
}
