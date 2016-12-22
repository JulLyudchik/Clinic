using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Model;

namespace Controller.Service
{
    public class Update
    {
        static UnitOfWork unitOfWork = new UnitOfWork();
        public static string update(Cabinet cabinet)
        {       
            unitOfWork.Cabinets.Update(cabinet);            
            unitOfWork.Save();
            return "Кабинет изменён.";
        }
        public static string update(Specialization specialization)
        {
            unitOfWork.Specializations.Update(specialization);
            unitOfWork.Save();
            return "Специализация изменена.";
        }
        public static string update(Diagnosis diagnosis)
        {
            unitOfWork.Diagnoses.Update(diagnosis);
            unitOfWork.Save();
            return "Диагноз изменен.";
        }
        public static string update(Drug drug)
        {
            unitOfWork.Drugs.Update(drug);
            unitOfWork.Save();
            return "Лекарство изменено.";
        }
        public static string update(Doctor doctor)
        {
            unitOfWork.Doctors.Update(doctor);
            unitOfWork.Save();
            return "Доктор изменен.";
        }
        public static string update(RegStation regStation)
        {
            unitOfWork.RegStations.Update(regStation);
            unitOfWork.Save();
            return "Участок изменен.";
        }
        public static string update(PatientCard patCard)
        {
            unitOfWork.PatientCards.Update(patCard);
            unitOfWork.Save();
            return "Карточка изменена.";
        }
    }
}
