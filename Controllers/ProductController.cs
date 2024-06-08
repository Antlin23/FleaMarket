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
        private readonly UserService _userService;
        private readonly SendGridService _sendGridService;
        private readonly ImageService _imageService;
        public ProductController(ProductService productService, UserService userService, SendGridService sendGridService, ImageService imageService)
        {
            _productService = productService;
            _userService = userService;
            _sendGridService = sendGridService;
            _imageService = imageService;
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
        public async Task<IActionResult> Market(SearchProductViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (viewModel.Category != null && viewModel.Category != "Alla kategorier" || viewModel.SearchString != null)
                {
                    viewModel = await _productService.GetProductsByFilterAsync(viewModel);
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
                    UserEntity user = await _userService.GetUserAsync(x => x.Id == viewModel.UserId);
                    var place = user.Place;

                    if(viewModel.Place != null)
                    {
                        await _userService.AddPlaceToUser(user.Id, viewModel.Place);
                    }

                    //if (viewModel.PlaceImage != null)
                    //{
                    //    await _userService.AddPlaceImageToUser(viewModel);

                    //    await _imageService.UploadUserPlaceImageAsync(user, viewModel.PlaceImage);
                    //}

                    var entity = await _productService.AddProduct(viewModel);


                    TempData["SuccessMessage"] = "Produkten lades till";

                    return RedirectToAction("Index", "Account");
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

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(Guid productId)
        {

            if (await _productService.DeleteProductAsync(productId))
            {
                TempData["ProductDeletedMessage"] = "Produkten togs bort";

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
