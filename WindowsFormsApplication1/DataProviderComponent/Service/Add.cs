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
    }
}
