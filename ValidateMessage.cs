namespace MRL.LibertyRising.Messages
{
    public class ValidateMessage
    {
        public int EntityTypeId { get; set; }
        public bool IsUnique { get; set; }
        public bool IsValid { get; set; }
        public string Value { get; set; }
    }
}
