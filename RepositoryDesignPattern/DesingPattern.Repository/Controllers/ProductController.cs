using DesignPattern.BusinessLayerRepository.Abstract;
using DesingPattern.EntityLayerRepository.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesingPattern.Repository.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;


        public ProductController(IProductService ProductService, ICategoryService categoryService)
        {
            _productService = ProductService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _productService.TGetList();
            return View(values);
        }
        public IActionResult Index2()
        {
            var values = _productService.TProductListWithCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult ProductAdd()
        {
            List<SelectListItem> values = (from x in _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Value = x.CategoryID.ToString(),
                                               Text = x.CategoryName
                                           }).ToList();
            ViewBag.v = values;
            
            
            return View();
        }
        [HttpPost]
        public IActionResult ProductAdd(Product product)
        {
            _productService.TInsert(product);
            return RedirectToAction("Index2");
        }

        public IActionResult ProductDelete(int id)
        {
            var detectedValues = _productService.TGetByID(id);
            _productService.TDelete(detectedValues);
            return RedirectToAction("Index2");

        }


        [HttpGet]
        public IActionResult ProductUpdate(int id)
        {
            List<SelectListItem> values = (from x in _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Value = x.CategoryID.ToString(),
                                               Text = x.CategoryName
                                           }).ToList();
            ViewBag.v = values;
            var detectedValues = _productService.TGetByID(id);
            return View(detectedValues);
        }
        [HttpPost]
        public IActionResult ProductUpdate(Product product)
        {

            _productService.TUpdate(product);
            return RedirectToAction("Index2");
        }
    }
}
