using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class PaymentController : Controller
{
    private readonly SwishAPIService _swishService;

    public PaymentController(SwishAPIService swishService)
    {
        _swishService = swishService;
    }

    public async Task<IActionResult> CreatePaymentRequest()
    {
        var result = await _swishService.MakePaymentRequestAsync();
        return Content(result);
    }
}
