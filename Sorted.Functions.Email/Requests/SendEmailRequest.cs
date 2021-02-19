namespace Sorted.Functions.Email.Requests
{
    public class SendEmailRequest
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}