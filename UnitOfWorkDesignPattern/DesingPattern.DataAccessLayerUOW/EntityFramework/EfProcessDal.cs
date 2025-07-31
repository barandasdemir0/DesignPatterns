using DesingPattern.DataAccessLayerUOW.Abstract;
using DesingPattern.DataAccessLayerUOW.Concrete;
using DesingPattern.DataAccessLayerUOW.Repositories;
using DesingPattern.EntityLayerUOW.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.DataAccessLayerUOW.EntityFramework
{
    public class EfProcessDal:GenericRepository<Process>,IProcessDal
    {
        public EfProcessDal(Context context):base(context)
        {
            
        }
    }
}
