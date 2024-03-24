using FleaMarket.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class PaymentController : Controller
{
    private readonly SwishAPIService _swishService;

    public PaymentController(SwishAPIService swishService)
    {
        _swishService = swishService;
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
                return RedirectToAction("Index", "Account");
            }
        }
        ModelState.AddModelError("", "Någon blev fel. Om felet kvarstår kontakta oss.");
        return View(viewModel);
    }
}
