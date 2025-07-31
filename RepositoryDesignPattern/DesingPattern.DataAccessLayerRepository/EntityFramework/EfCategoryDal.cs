using DesingPattern.DataAccessLayerRepository.Abstract;
using DesingPattern.DataAccessLayerRepository.Concrete;
using DesingPattern.DataAccessLayerRepository.Repositories;
using DesingPattern.EntityLayerRepository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.DataAccessLayerRepository.EntityFramework
{
    public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    {
        public EfCategoryDal(Context context):base(context)
        {
            
        }
    }
}
