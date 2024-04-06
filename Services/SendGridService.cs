using SendGrid.Helpers.Mail;
using SendGrid;
using Azure;
using System;
using FleaMarket.Models.Entities;

namespace FleaMarket.Services
{
    public class SendGridService
    {
        private readonly IConfiguration _config;

        public SendGridService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendEmailAsync(string confLink, UserEntity userToConfirm)
        {
            var apiKey = _config["SendGridApiKey"];

            var client = new SendGridClient(apiKey);

            var msg = new SendGridMessage()
            {
                From = new EmailAddress("tradetrails.service@gmail.com", "TradeTrails"),
                Subject = "Bekräfta din e-postadress",
                HtmlContent = $"<p>För att slutföra registreringen av ditt konto, vänligen bekräfta din e-postadress <a href=\"{confLink}\"> här.</a></p>"
            };
            //Use this in production
            //msg.AddTo(new EmailAddress(userToConfirm.Email, userToConfirm.UserName));
            msg.AddTo(new EmailAddress("anton.jumkil@gmail.com", "TrattTratt"));
            var response = await client.SendEmailAsync(msg);
        }
    }
}
