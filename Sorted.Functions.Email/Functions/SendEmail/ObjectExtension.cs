using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sorted.Functions.Email.Functions.SendEmail
{
    public static class ObjectExtension
    {
        public static string ToJson(this object thisObject, bool writeIndented = true)
        {
            if (thisObject is string stringObject)
            {
                return stringObject;
            }

            return JsonSerializer
                .Serialize(thisObject, new JsonSerializerOptions
                {
                    WriteIndented = writeIndented,
                    IgnoreNullValues = true,
                    Converters = { new JsonStringEnumConverter() }
                });
        }
    }
}