using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayerRepository.Abstract
{
    public interface IGenericService<T> where T:class // burası controller tarafında çağıracağımız metotlar
    {
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);

        List<T> TGetList();
        T TGetByID(int id);

        //NEDEN T EKLEDİK HEM DAL DA HEMDE BL DA KARIŞMASIN DİYE
    }
}
