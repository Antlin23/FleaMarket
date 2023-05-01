using FleaMarket.Models.Entities;
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
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductEntity productEntity)
        {

            if (ModelState.IsValid)
            {

                //om den lyckas skapa en användare 
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
