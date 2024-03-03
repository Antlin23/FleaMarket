using FleaMarket.Models.Entities;
using FleaMarket.Models.ViewModels;
using FleaMarket.Services;
using Microsoft.AspNetCore.Authorization;
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

        public IActionResult Market(string marketName)
        {
            ViewData["MarketName"] = marketName;

            return View();
        }

        [HttpPost]
        public IActionResult Market(SearchProductViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (viewModel.Category != null && viewModel.Category != "Alla kategorier" || viewModel.SearchString != null)
                {
                    viewModel = _productService.GetProductsByFilter(viewModel);
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

        [Authorize]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(AddProductViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var entity = await _productService.AddProduct(viewModel);

                    if (viewModel.Image != null)
                    {
                        await _productService.UploadImageAsync(entity, viewModel.Image);
                    }

                    return RedirectToAction("ProductCreated", "product");
                }
                catch
                {
                    ModelState.AddModelError("", "Någon gick fel när produkten skulle skapas");
                    return View(viewModel);
                }
            }
            ModelState.AddModelError("", "Någon gick fel när produkten skulle skapas");
            return View(viewModel);
        }

        [Authorize]
        public IActionResult ProductCreated()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(Guid productId)
        {

            if (await _productService.DeleteProductAsync(productId))
            {
                return RedirectToAction("Index", "Account");
            }
            else
            {
                ModelState.AddModelError("", "Någon blev fel när produkten skulle tas bort");
            }

            return View(productId);
        }

    }
}
