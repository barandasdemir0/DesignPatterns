using DesingPattern.EntityLayerRepository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayerRepository.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> TProductListWithCategory();
    }
}
