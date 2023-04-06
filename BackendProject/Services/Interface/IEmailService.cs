namespace BackendProject.Services.Interface
{
    public interface IEmailService
    {
        void Send(string to, string subject, string html);
    }
}
