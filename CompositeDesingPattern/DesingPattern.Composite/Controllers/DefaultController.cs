using DesingPattern.Composite.CompositePattern;
using DesingPattern.Composite.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesingPattern.Composite.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value = _context.Categories?.Include(x => x.Products).ToList();
            var values = Recursive(value, new Category { CategoryName = "FirstCategory", CategoryID = 0 }, new ProductComposite(0, "FirstComposite"));
            ViewBag.v = values;
            return View();
        }

        public ProductComposite Recursive(List<Category> categories,Category firstCategory,ProductComposite firstComposite,ProductComposite leaf= null)
        {
            categories.Where(x => x.UpperCategoryID == firstCategory.CategoryID).ToList().ForEach(y =>
            {
                var productComposite = new ProductComposite(y.CategoryID, y.CategoryName);

                y.Products?.ToList().ForEach(z =>
                {
                    productComposite.Add(new ProductComponent(z.ProductID, z.ProductName));
                });
                if (leaf!= null)
                {
                    leaf.Add(productComposite);
                }
                else
                {
                    firstComposite.Add(productComposite);
                }
                Recursive(categories, y, firstComposite, productComposite);
            });
            return firstComposite;
        }
    }
}
