using DesignPattern.BusinessLayerRepository.Abstract;
using DesingPattern.EntityLayerRepository.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DesingPattern.Repository.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _categoryService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            _categoryService.TInsert(category);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryDelete(int id)
        {
            var detectedValues = _categoryService.TGetByID(id);
            _categoryService.TDelete(detectedValues);
            return RedirectToAction("Index");
           
        }


        [HttpGet]
        public IActionResult CategoryUpdate(int id)
        {
            var detectedValues = _categoryService.TGetByID(id);
            return View(detectedValues);
        }
        [HttpPost]
        public IActionResult CategoryUpdate(Category category)
        {
           
            _categoryService.TUpdate(category);
            return RedirectToAction("Index");
        }
    }
}
