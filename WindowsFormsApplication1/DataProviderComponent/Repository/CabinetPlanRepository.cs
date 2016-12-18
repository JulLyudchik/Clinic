using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller.Repository
{
    public class CabinetPlanRepository:Repository<CabinetPlan>
    {
        public CabinetPlanRepository(Context context): base(context)
        {
        }
    }
}
