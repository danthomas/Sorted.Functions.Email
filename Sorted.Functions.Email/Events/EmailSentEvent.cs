namespace Sorted.Functions.Email.Events
{
    public class EmailSentEvent
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
    }
}