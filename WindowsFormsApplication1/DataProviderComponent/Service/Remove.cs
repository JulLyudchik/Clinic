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
    }
}
