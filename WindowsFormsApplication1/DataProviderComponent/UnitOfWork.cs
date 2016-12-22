using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.Repository;

namespace Controller
{
    public class UnitOfWork : IDisposable
    {
        private static readonly Context Context = new Context();

        private CabinetPlanRepository cabinetPlanRepository = new CabinetPlanRepository(Context);
        private CabinetRepository cabinetRepository = new CabinetRepository(Context);
        private DiagnosisRepository diagnosisRepository = new DiagnosisRepository(Context);
        private DoctorRepository doctorRepository = new DoctorRepository(Context);
        private DrugRepository drugRepository = new DrugRepository(Context);
        private RegStationRepository regStationRepository = new RegStationRepository(Context);
        private SpecializationRepository specializationRepository = new SpecializationRepository(Context);
        private StreetRepository streetRepository = new StreetRepository(Context);
        private PatientCardRepository patCardRepository = new PatientCardRepository(Context);
        private VisitRepository visitRepository = new VisitRepository(Context);
        public CabinetPlanRepository CabinetPlans
        {
            get
            {
                if (cabinetPlanRepository == null)
                    cabinetPlanRepository = new CabinetPlanRepository(Context);
                return cabinetPlanRepository;
            }
        }
        public CabinetRepository Cabinets
        {
            get
            {
                if (cabinetRepository == null)
                    cabinetRepository = new CabinetRepository(Context);
                return cabinetRepository;
            }
        }
        public DiagnosisRepository Diagnoses
        {
            get
            {
                if (diagnosisRepository == null)
                    diagnosisRepository = new DiagnosisRepository(Context);
                return diagnosisRepository;
            }
        }
        public DoctorRepository Doctors
        {
            get
            {
                if (doctorRepository == null)
                    doctorRepository = new DoctorRepository(Context);
                return doctorRepository;
            }
        }
        public DrugRepository Drugs
        {
            get
            {
                if (drugRepository == null)
                    drugRepository = new DrugRepository(Context);
                return drugRepository;
            }
        }
        public RegStationRepository RegStations
        {
            get
            {
                if (regStationRepository == null)
                    regStationRepository = new RegStationRepository(Context);
                return regStationRepository;
            }
        }
        public SpecializationRepository Specializations
        {
            get
            {
                if (specializationRepository == null)
                    specializationRepository = new SpecializationRepository(Context);
                return specializationRepository;
            }
        }
        public StreetRepository Streets
        {
            get
            {
                if (streetRepository == null)
                    streetRepository = new StreetRepository(Context);
                return streetRepository;
            }
        }
        public PatientCardRepository PatientCards
        {
            get
            {
                if (patCardRepository == null)
                    patCardRepository = new PatientCardRepository(Context);
                return patCardRepository;
            }
        }
        public VisitRepository Visits
        {
            get
            {
                if (visitRepository == null)
                    visitRepository = new VisitRepository(Context);
                return visitRepository;
            }
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
