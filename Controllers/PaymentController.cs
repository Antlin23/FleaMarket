using FleaMarket.Models.ViewModels;
using FleaMarket.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class PaymentController : Controller
{
    private readonly SwishAPIService _swishService;
    private readonly UserService _userService;

    public PaymentController(SwishAPIService swishService, UserService userService)
    {
        _swishService = swishService;
        _userService = userService;
    }

    public IActionResult CreatePaymentRequest()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> CreatePaymentRequest(CreatePaymentViewModel viewModel)
    {
        if(ModelState.IsValid)
        {
            bool result = await _swishService.MakePaymentRequestAsync(viewModel.PayerPhoneNumber);

            if(result)
            {
                //här måste user bli isActivatedSeller = true
                await _userService.MakeUserActiveSellerAsync(User.FindFirst("Id")?.Value);
                
                return RedirectToAction("Index", "Account");
            }
        }
        ModelState.AddModelError("", "Någon blev fel. Om felet kvarstår kontakta oss.");
        return View(viewModel);
    }
}
