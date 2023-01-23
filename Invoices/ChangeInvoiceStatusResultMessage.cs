
namespace MRL.LibertyRising.Messages.Invoices
{
    public class ChangeInvoiceStatusResultMessage
    {
        public InvoiceMessage Invoice { get; set; }
        public bool Successful { get; set; }
}
}
