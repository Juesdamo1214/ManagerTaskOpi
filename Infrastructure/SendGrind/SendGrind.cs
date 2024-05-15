using Application.Interface;
using Infrastructure.Resource;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Infrastructure.SendGrind
{
    public class SendGrind(string apikey) : ISendNotificationTask
    {
        private readonly string Apikey = apikey;
        public async Task SendNotificationTask(string email, string contentText, string user)
        {
            var client = new SendGridClient(Apikey);
            var from = new EmailAddress(Constants.Email_Opi, Constants.Usuario);
            var subject = Constants.Email_Opi;
            var to = new EmailAddress(email, user);
            var plainTextContent = contentText;
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, contentText, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
