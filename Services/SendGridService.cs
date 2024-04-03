using SendGrid.Helpers.Mail;
using SendGrid;
using Azure;

namespace FleaMarket.Services
{
    public class SendGridService
    {
        private readonly IConfiguration _config;

        public SendGridService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendEmailAsync()
        {
            var apiKey = _config["SendGridApiKey"];

            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("anton.jumkil@gmail.com", "TradeTrails"),
                Subject = "Bekräfta din e-postadress",
                PlainTextContent = "För att slutföra registreringen av ditt konto, var vänlig och bekräfta" +
                " din e-postadress"
            };
            msg.AddTo(new EmailAddress("tratttestemail@gmail.com", "bestseller58"));
            var response = await client.SendEmailAsync(msg);
        }
    }
}
