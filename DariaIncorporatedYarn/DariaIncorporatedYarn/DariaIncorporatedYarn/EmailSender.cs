using AspNetCore.SimpleEmail;
using Microsoft.AspNetCore.Identity;

namespace DariaIncorporatedYarn
{
    public class EmailSender<TUser> : IEmailSender<TUser> where TUser : class
    {
        
public Task SendConfirmationLinkAsync(TUser user, string email, string confirmationLink)
        {
            var emailSender = new Mail();
            emailSender.Sender = "daria.green20@gmail.com";
            emailSender.To = "daria.green20@gmail.com";
            emailSender.Subject = "Thank you for Joining!";
            emailSender.Body = email;


            // Send the email asynchronously
            emailSender.SendAsync();
            return Task.CompletedTask;
        }

        public Task SendPasswordResetLinkAsync(TUser user, string email, string resetLink)
        {
            throw new NotImplementedException();
        }

        public Task SendPasswordResetCodeAsync(TUser user, string email, string resetCode)
        {
            throw new NotImplementedException();
        }
    }
}
