using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Models
{
    public class EmailSenderOptions
    {
        public required string Host { get; set; }
        public required int Port { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
    public class EmailSender : IEmailSender
    {
        private EmailSenderOptions options;

        public EmailSender(IOptions<EmailSenderOptions> options)
        {
            this.options = options.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {

            MailMessage payload = new(new MailAddress(options.Username), new MailAddress(email))
            {
                IsBodyHtml = true,
                Subject = subject,
                Body = htmlMessage
            };
            SmtpClient smtp = new SmtpClient
            {
                Credentials = new System.Net.NetworkCredential(options.Username, options.Password),
                Port = options.Port,
                Host = options.Host,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false
            };
            try
            {
                await smtp.SendMailAsync(payload);
            }
            catch (Exception)
            {
                smtp.Dispose();
            }
        }
    }
}
