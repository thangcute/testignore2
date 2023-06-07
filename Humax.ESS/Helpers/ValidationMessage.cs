using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Helpers
{
    public class ValidationMessage
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; }

        public string Message { get; }

        public ValidationMessage(string field, string message)
        {
            Field = field != string.Empty ? field.Replace("model.", "") : null;
            Message = message;
        }
    }
}
