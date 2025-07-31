using DesingPattern.DataAccessLayerRepository.Abstract;
using DesingPattern.DataAccessLayerRepository.Concrete;
using DesingPattern.DataAccessLayerRepository.Repositories;
using DesingPattern.EntityLayerRepository.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.DataAccessLayerRepository.EntityFramework
{
    public class EfProductDal:GenericRepository<Product>,IProductDal
    {
        private readonly Context _context;
        public EfProductDal(Context context):base(context)
        {
            _context = context;
        }

        public List<Product> ProductListWithCategory()
        {
           return _context.Products.Include(x => x.Category).ToList();
            
        }
    }
}
