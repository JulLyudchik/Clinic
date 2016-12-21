using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Model;

namespace Controller.Service
{
    
    public class Add
    {
        static UnitOfWork unitOfWork = new UnitOfWork();
        public static bool error;
        public static string add(Cabinet cabinet)
        {
            if (unitOfWork.Cabinets.GetAll().Find(cab => cab.number == cabinet.number) == null)
            {
                unitOfWork.Cabinets.Add(cabinet);
                unitOfWork.Save();
                return "Новый кабинет создан.";
            }
            else return "Такой кабинет уже существует!";
        }
        public static string add(Specialization specialization)
        {
            if (unitOfWork.Specializations.GetAll().Find(spec => spec.name == specialization.name) == null)
            {
                unitOfWork.Specializations.Add(specialization);
                unitOfWork.Save();
                return "Новая специализация создана.";
            }
            else return "Такая специализация уже существует!";
        }
        public static string add(Drug drug)
        {
            if (unitOfWork.Drugs.GetAll().Find(drugg => drugg.name == drug.name) == null)
            {
                unitOfWork.Drugs.Add(drug);
                unitOfWork.Save();
                return "Новое лекарство создано.";
            }
            else return "Такое лекарство уже существует!";
        }
        public static string add(Diagnosis diagnosis)
        {
            if (unitOfWork.Diagnoses.GetAll().Find(diag => diag.name == diagnosis.name) == null)
            {
                unitOfWork.Diagnoses.Add(diagnosis);
                unitOfWork.Save();
                return "Новый диагноз создан.";
            }
            else return "Такой диагноз уже существует!";
        }
        public static string add(Doctor doctor)
        {
            if (unitOfWork.Doctors.GetAll().Find(doc => doc.name == doctor.name) == null)
            {
                unitOfWork.Doctors.Add(doctor);
                unitOfWork.Save();
                return "Новый врач добавлен.";
            }
            else return "Такой врач уже существует!";
        }
        public static string add(RegStation regStation)
        {
            if (unitOfWork.RegStations.GetAll().Find(regSt => regSt.name == regStation.name) == null)
            {
                unitOfWork.RegStations.Add(regStation);
                unitOfWork.Save();
                return "Новый участок добавлен.";
            }
            else return "Такой участок уже существует!";
        }
        public static string add(Street street)
        {
            error=false;
            if (unitOfWork.Streets.GetAll().Find(str => str.name == street.name) == null)
            {
                unitOfWork.Streets.Add(street);
                unitOfWork.Save();
                return "Новая улица добавлена.";
            }
            else
            {
                error = true;
                return "Такая улица уже существует!";
            } 
        }
    }
}
