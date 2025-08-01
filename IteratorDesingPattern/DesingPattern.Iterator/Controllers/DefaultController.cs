using DesingPattern.Iterator.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesingPattern.Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> strings = new List<string>();
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Almanya", CityName = "Berlin", VisitName= "Berlin Kapısı" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Fransa", CityName = "Paris", VisitName = "Paris Kulesi" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "İtalya", CityName = "Venedik", VisitName = "Gondol " });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "İtalya", CityName = "Roma", VisitName = "Kolezyum " });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "çek", CityName = "Prag", VisitName = "Meydan" });

            var iterator = visitRouteMover.CreateIterator();
            while (iterator.NextLocation())
            {
                strings.Add(iterator.CurrentItem.CountryName + iterator.CurrentItem.CityName + iterator.CurrentItem.VisitName);
            }
            ViewBag.v = strings;
            return View();
        }
    }
}
