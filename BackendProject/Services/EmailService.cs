using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;
using BackendProject.Services.Interface;

namespace BackendProject.Services.Email
{
    public class EmailService : IEmailService
    {

        public void Send(string userEmail, string subject, string body)
        { 
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("tsalmanzade6@gmail.com")); 
            email.To.Add(MailboxAddress.Parse(userEmail));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Plain) { Text = "Salam" };
       
            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, false); 
            smtp.Authenticate("tsalmanzade6@gmail.com", "zzpdmzvqolkumsrc");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
