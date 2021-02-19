
using Sorted.Functions.Email.Requests;
using Sorted.Functions.Email.Responses;
using Sorted.Functions.Email.Events;

namespace Sorted.Functions.Email.Functions.SendEmail
{
    public interface ISendEmailHost
    {
        //void LogMessage(string level, string message);
        void Raise(EmailSentEvent @event);
        void Raise(SendEmailFailedEvent @event);
    }
}