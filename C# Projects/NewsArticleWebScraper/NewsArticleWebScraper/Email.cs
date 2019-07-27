using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace NewsArticleWebScraper
{
    class Email
    {
        private string EmailRecipient { get; set; }
        private string EmailSubject { get; set; }
        private string EmailBody { get; set; }

        private readonly NameValueCollection _appSettings = ConfigurationManager.AppSettings;
        internal static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public void BuildEmail(string subject, string body)
        {
            EmailRecipient = _appSettings["EmailRecipient"];
            EmailSubject = subject;
            EmailBody = body;

            SendEmail();
        }

        private void SendEmail()
        {
            try
            {
                SmtpClient client = new SmtpClient
                {
                    Host = "10.0.0.13",
                    Port = 25,
                    UseDefaultCredentials = false
                };
                MailMessage msg = new MailMessage
                {
                    From = new MailAddress(_appSettings["EmailSender"]),
                    Subject = EmailSubject,
                    Body = EmailBody
                };

                msg.To.Add(EmailRecipient);

                client.Send(msg);

                _logger.Log(LogLevel.Trace, $"Sender: {_appSettings["ErrorEmailSender"]}, Recipient: {_appSettings["ErrorEmailRecipient"]}, Subject: {EmailSubject}, Body: {EmailBody}");
            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, $"Sender: {_appSettings["ErrorEmailSender"]}, Recipient: {_appSettings["ErrorEmailRecipient"]}, Subject: {EmailSubject}, Body: {EmailBody}, Error: {e}");
            }
        }
    }
}
