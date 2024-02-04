using FleaMarket.Models.Entities;
using FleaMarket.Models.ViewModels;
using FleaMarket.Services;
using Microsoft.AspNetCore.Mvc;

namespace FleaMarket.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UlvaKvarn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UlvaKvarn(SearchProductViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (viewModel.Category != null && viewModel.Category != "Alla kategorier")
                {
                    viewModel = _productService.GetProductsByCategory(viewModel);
                    return View(viewModel);
                }
                else if (viewModel.Category == "Alla kategorier")
                {
                    viewModel.NoProducts = null;
                }
                else
                {
                    viewModel.NoProducts = "No products was found";

                }
            }
            return View(viewModel);
        }

        public IActionResult VaksalaTorg()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductEntity productEntity)
        {

            if (ModelState.IsValid)
            {

                if (await _productService.AddProduct(productEntity)) //lyckas den skapa returnas sant
                {
                    return RedirectToAction("ProductCreated", "product");
                }
                else
                {
                    ModelState.AddModelError("", "Någon gick fel när produkten skulle skapas");
                }
                
            }
            return View(productEntity);
        }

        public IActionResult ProductCreated()
        {
            return View();
        }

    }
}
