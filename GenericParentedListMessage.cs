namespace MRL.LibertyRising.Messages
{
    public class GenericParentedListMessage<TValue>: GenericListMessage<TValue>
    {
        public int ParentId { get; set; }
    }
}