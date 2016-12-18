using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller.Repository
{
    public class DrugRepository:Repository<Drug>
    {
        public DrugRepository(Context context): base(context)
        {
        }
    }
}
