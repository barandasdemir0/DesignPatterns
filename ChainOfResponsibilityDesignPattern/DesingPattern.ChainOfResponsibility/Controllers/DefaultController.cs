using DesingPattern.ChainOfResponsibility.ChainOfResponsibility;
using DesingPattern.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesingPattern.ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerAsistant = new ManagerAsistant();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();

            treasurer.SetNextApprover(managerAsistant);
            managerAsistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);


            treasurer.ProcessRequest(model);
            //managerAsistant.ProcessRequest(model);
            //manager.ProcessRequest(model);
            return View();
        }
    }
}
