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
            return "Кабинет изменён";
        }
    }
}
