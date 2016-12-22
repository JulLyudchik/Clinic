using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Model;

namespace Controller.Service
{
    public class Remove
    {
        static UnitOfWork unitOfWork = new UnitOfWork();
        public static string remove(Cabinet cabinet)
        {
            unitOfWork.Cabinets.Remove(cabinet);
            unitOfWork.Save();
            return "Кабинет удалён.";          
        }
        public static string remove(Specialization specialization)
        {
            unitOfWork.Specializations.Remove(specialization);
            unitOfWork.Save();
            return "Специализация удалена.";
        }
        public static string remove(Diagnosis diagnosis)
        {
            unitOfWork.Diagnoses.Remove(diagnosis);
            unitOfWork.Save();
            return "Диагноз удален.";
        }
        public static string remove(Drug drug)
        {
            unitOfWork.Drugs.Remove(drug);
            unitOfWork.Save();
            return "Лекарство удалено.";
        }
        public static string remove(Street street)
        {
            unitOfWork.Streets.Remove(street);
            unitOfWork.Save();
            return "Улица удалена.";
        }
        public static string remove(Doctor doctor)
        {
            unitOfWork.Doctors.Remove(doctor);
            unitOfWork.Save();
            return "Доктор удален.";
        }
        public static string remove(RegStation regStation)
        {
            unitOfWork.RegStations.Remove(regStation);
            unitOfWork.Save();
            return "Участок удален.";
        }
        public static string remove(PatientCard patCard)
        {
            unitOfWork.PatientCards.Remove(patCard);
            unitOfWork.Save();
            return "Карточка пациента удалена.";
        }
    }
}
