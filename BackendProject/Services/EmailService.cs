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
            email.From.Add(MailboxAddress.Parse("toghrulkhs@code.edu.az")); 
            email.To.Add(MailboxAddress.Parse(userEmail));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = body };


            
            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);  //465 for gmail new
            smtp.Authenticate("toghrulkhs@code.edu.az", "lkfcesrcfermf");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}