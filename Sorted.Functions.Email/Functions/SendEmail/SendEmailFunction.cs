using System;
using System.IO;
using Sorted.Functions.Core;
using Sorted.Functions.Email.Requests;
using Sorted.Functions.Email.Responses;
using Sorted.Functions.Email.Events;

namespace Sorted.Functions.Email.Functions.SendEmail
{
    public partial class SendEmailFunction : IFunction
    {
        private readonly ISendEmailHost _host;

        public SendEmailFunction(ISendEmailHost host)
        {
            _host = host;
        }

        public SendEmailResponse RespondTo(SendEmailRequest request)
        {
            var fileName = DateTime.Now.ToString("O").Replace(":", "").Replace("-", "");

            File.WriteAllText($@"c:\temp\emails\email{fileName}.json", request.ToJson());

            _host.Raise(new EmailSentEvent
            {
                EmailAddress = request.EmailAddress,
                Subject = request.Subject,
            });

            return new SendEmailResponse { Success = true };
        }
    }
}
