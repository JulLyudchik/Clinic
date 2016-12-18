using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller.Repository
{
    public class DoctorRepository:Repository<Doctor>
    {
        public DoctorRepository(Context context): base(context)
        {
        }
    }
}
