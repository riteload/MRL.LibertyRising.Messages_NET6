using System.Collections.Generic;
using System.Linq;

namespace MRL.LibertyRising.Messages
{
    public class ValidationResultMessage
    {
        public IDictionary<string, string> Errors { get; set; }
        public bool HasErrors => Errors.Any();
        public IDictionary<string, string> ValidationResult { get; set; }
    }
}
