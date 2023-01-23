using System.Collections.Generic;

namespace MRL.LibertyRising.Messages.Questions
{
    public class QuestionMessage
    {
        public string Identifier { get; set; }
        public string Text { get; set; }

        public IEnumerable<ChoiceMessage> Choices { get; set; }
    }
}
