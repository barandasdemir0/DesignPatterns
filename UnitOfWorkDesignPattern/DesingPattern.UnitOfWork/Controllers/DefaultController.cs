using DesingPattern.BusinessLayerUOW.Abstract;
using DesingPattern.EntityLayerUOW.Concrete;
using DesingPattern.UnitOfWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesingPattern.UnitOfWork.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(CustomerViewModel model)
        {
            var values1 = _customerService.TGetByID(model.SenderID);
            var values2 = _customerService.TGetByID(model.ReceiverID);

            values1.CustomerBalance -= model.Amount;
            values2.CustomerBalance += model.Amount;


            List<Customer> modifiedCustomer = new List<Customer>()
            {
                values1,
                values2

            };

            _customerService.TMultiUpdate(modifiedCustomer);

            return View();
        }
    }
}
