using DesingPattern.Facade.DAL;
using DesingPattern.Facade.Facade;
using Microsoft.AspNetCore.Mvc;

namespace DesingPattern.Facade.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        OrderFacade facade = new OrderFacade();



        [HttpGet]
        public IActionResult AddNewCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return RedirectToAction("CustomerList");
        }

        public IActionResult CustomerList()
        {
            var values= context.Customers.ToList();
            return View(values);
        }










        [HttpGet]
        public IActionResult AddProductCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProductCustomer(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        public IActionResult ProductList()
        {
            var values = context.Products.ToList();
            return View(values);
        }



        [HttpGet]
        public IActionResult OrderDetailsStart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrderDetailsStart(int customerID, int producID, int orderID, int productCount, decimal productPrice)
        {
            



            facade.CompleteOrderDetail( customerID,  producID,  orderID,  productCount,  productPrice);
            return RedirectToAction("OrderList");
        }
        [HttpGet]
        public IActionResult OrderStart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrderStart(int customerID)
        {
            



            facade.CompleteOrder( customerID);
            return RedirectToAction("OrderList");
        }

        public IActionResult OrderList()
        {
            var values = context.Products.ToList();
            return View(values);
        }

    }
}
