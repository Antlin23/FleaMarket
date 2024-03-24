using System;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class SwishAPIService
{
    private readonly HttpClient _httpClient;

    public SwishAPIService()
    {
        // Load certificate files
        var certificate = new X509Certificate2("./Certificates/Swish_Merchant_TestCertificate_1234679304.p12", "swish", X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet);
        // code from 3.5 var cert = new X509Certificate2("./Certificates/Swish_Merchant_TestCertificate_1234679304.p12");
        
        //src="~/Images/Products/@product.ImageUrl"
        var handler = new HttpClientHandler();
        handler.ClientCertificates.Add(certificate);

        // Create HttpClient with custom handler
        _httpClient = new HttpClient(handler);
        _httpClient.BaseAddress = new Uri("https://mss.cpc.getswish.net/");
    }

    public async Task<string> MakePaymentRequestAsync()
    {
        // Generate a unique instruction ID
        var instructionId = Guid.NewGuid().ToString().ToUpper();

        // Setup payment data
        var data = new
        {
            payeePaymentReference = "0123456788",
            callbackUrl = "https://example.com/swishcallback",
            payeeAlias = "1234679305",
            currency = "SEK",
            amount = "110",
            message = "Hejsan detta är meddelandet"
            //payerAlias = "4671234768"
        };


        // Serialize data
        var jsonData = JsonConvert.SerializeObject(data);

        // Create and send HTTP request
        var response = await _httpClient.PutAsync($"/swish-cpcapi/api/v2/paymentrequests/{instructionId}",
            new StringContent(jsonData, Encoding.UTF8, "application/json"));

        if (response.IsSuccessStatusCode)
        {
            return "Payment request created. Status Code: " + response.StatusCode;
        }
        else
        {
            return "Failed to create payment request. Status Code: " + response.StatusCode;
        }
        

    }

}
