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

        var handler = new HttpClientHandler();
        handler.ClientCertificates.Add(certificate);

        // Create HttpClient with custom handler
        _httpClient = new HttpClient(handler);
        _httpClient.BaseAddress = new Uri("https://mss.cpc.getswish.net/");
    }

    public string GenerateSwishUuid()
    {
        // Generate a version 4 (random) UUID
        Guid uuid = Guid.NewGuid();
        // Convert to string, remove hyphens, and convert to uppercase
        string swishUuid = uuid.ToString().Replace("-", "").ToUpper();
        return swishUuid;
    }

    public async Task<bool> MakePaymentRequestAsync(string payerPhoneNumber)
    {

        // Generate a unique instruction ID
        var instructionId = GenerateSwishUuid();

        // Setup payment data
        var data = new
        {
            payeePaymentReference = "1234567GLHF",
            callbackUrl = "https://example.com/swishcallback",
            //Betalningsmottagare
            payeeAlias = "1234679304",
            currency = "SEK",
            amount = "30",
            message = "Jag vill aktivera mitt säljkonto.",
            //Numret till den som ska betala
            payerAlias = payerPhoneNumber
        };

        // Serialize data
        var jsonData = JsonConvert.SerializeObject(data);

        // Create and send HTTP request
        var response = await _httpClient.PutAsync($"/swish-cpcapi/api/v2/paymentrequests/{instructionId}",
            new StringContent(jsonData, Encoding.UTF8, "application/json"));

        if (response.IsSuccessStatusCode)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}