using DesingPattern.Facade.DAL;

namespace DesingPattern.Facade.Facade
{
    public class AddOrderDetail
    {
        Context context = new Context();
        public void AddNewOrderDetail(OrderDetail orderDetail)
        {
            context.OrderDetails.Add(orderDetail);
            context.SaveChanges();
        }
    }
}
