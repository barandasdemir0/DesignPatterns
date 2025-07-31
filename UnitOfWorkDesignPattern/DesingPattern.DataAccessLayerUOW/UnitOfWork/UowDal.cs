using DesingPattern.DataAccessLayerUOW.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.DataAccessLayerUOW.UnitOfWork
{
    public class UowDal : IUowDal
    {

        private readonly Context _context;

        public UowDal(Context context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
