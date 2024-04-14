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

        public async Task SendEmailAsync(SendGridMessage message)
        {
            //Using User secrets, only works in development environment
            // var apiKey = _config["SendGridApiKey"];

            var apiKey = "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";

            var client = new SendGridClient(apiKey);

            //Use this in production
            //msg.AddTo(new EmailAddress(userToConfirm.Email, userToConfirm.UserName));
            message.AddTo(new EmailAddress("anton.jumkil@gmail.com", "TrattTratt"));
            var response = await client.SendEmailAsync(message);
        }
    }
}
