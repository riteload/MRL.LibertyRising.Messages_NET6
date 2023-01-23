namespace MRL.LibertyRising.Messages
{
    public class GenericListMessage<TValue>
    {
        public TValue Value { get; set; }
        public string Name { get; set; }
    }
}