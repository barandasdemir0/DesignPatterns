using DesingPattern.Facade.DAL;

namespace DesingPattern.Facade.Facade
{
    public class OrderFacade
    {
        Order order = new Order();
        OrderDetail orderDetail = new OrderDetail();
        ProductStock productStock = new ProductStock();
        AddOrder addOrder = new AddOrder();
        AddOrderDetail addOrderDetail = new AddOrderDetail();


        public void CompleteOrderDetail(int customerID,int producID,int orderID,int productCount,decimal productPrice)
        {
           

            orderDetail.OrderID = orderID;
            orderDetail.CustomerID = customerID;
            orderDetail.ProductID = productCount;
            orderDetail.ProductCount = productCount;
            orderDetail.ProductPrice = productPrice;
            decimal totalProductPrice = productCount*productPrice;
            orderDetail.ProductTotalPrice = totalProductPrice;

            addOrderDetail.AddNewOrderDetail(orderDetail);



            productStock.StockDecrease(producID, productCount);
        }

        
          public void CompleteOrder(int customerId)
        {
            order.CustomerID = customerId;
            addOrder.AddNewOrder(order);
        }
    }
}
