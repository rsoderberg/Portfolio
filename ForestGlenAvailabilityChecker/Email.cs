using System.Collections.Specialized;
using System.Configuration;
using System.Net.Mail;

namespace ForestGlenAvailabilityChecker
{
    internal class Email
    {
        private string EmailRecipient { get; set; }
        private string EmailSubject { get; set; }
        private string EmailBody { get; set; }

        private readonly NameValueCollection _appSettings = ConfigurationManager.AppSettings;

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
            }
            catch (Exception e)
            {
            }
        }
    }
}