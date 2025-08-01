using DesingPattern.Mediator.Commands;
using DesingPattern.Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesingPattern.Mediator.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllProductQuery());
            return View(values);
        }

        public async Task<IActionResult> GetProduct(int id)
        {
            var value = await _mediator.Send(new GetProductByIDQuery(id));
            return View(value);
        }


        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _mediator.Send(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
           var values = await _mediator.Send(new GetUpdateProductByIDQuery(id));
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand command)
        {
            await _mediator.Send( command);
           return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Add()
        {
           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(CreateProductCommand command)
        {
            await _mediator.Send( command);
           return RedirectToAction("Index");
        }
    }
}
