using System;
using System.ComponentModel.DataAnnotations;

namespace MRL.LibertyRising.Messages.QuickPay
{
    public class QuickPayRegistrationDataMessage
    {

        [Display(Name = "Business Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Company Email")]
        public string CompanyEmail { get; set; }

        [Display(Name = "Company Phone")]
        public string CompanyPhone { get; set; }


        [Display(Name = "Address Line 1")]
        public string Address1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }

        [Display(Name = "State")]
        public int? StateId { get; set; }

        public string City { get; set; }

        [Display(Name = "Postal Code")]
        public string Zipcode { get; set; }

        public string Website { get; set; }


        [Display(Name = "FEIN Number")]
        public string FeinNumber { get; set; }

        [Display(Name = "Owner Name")]
        public string OwnerName { get; set; }

        [Display(Name = "Business Type")]
        public string BusinessType { get; set; }

        [Display(Name = "DUNS Number")]
        public string DunsNumber { get; set; }

        [Display(Name = "Business Start Date")]
        public DateTime? Date { get; set; }

        [Display(Name = "Accounts Payable")]
        public string AccountsPayable { get; set; }


        [Display(Name = "Billing Address Line 1")]
        public string BillingAddress1 { get; set; }

        [Display(Name = "Billing Address Line 2")]
        public string BillingAddress2 { get; set; }

        [Display(Name = "Billing Address City")]
        public string BillingCity { get; set; }

        [Display(Name = "Billing Address State")]
        public int? BillingStateId { get; set; }

        [Display(Name = "Billing Address Postal Code")]
        public string BillingZipcode { get; set; }

        [Display(Name = "Website")]
        public string BillingWebsite { get; set; }


        [Display(Name = "Net Terms")]
        public int? NetTermId { get; set; }

        [Display(Name = "Invoice Method")]
        public int? InvoiceMethodId { get; set; }

        [Display(Name = "Payment Method")]
        public int? PaymentMethodId { get; set; }

        [Display(Name = "Payment Date")]
        public int? PaymentDateId { get; set; }



        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }
        
        [Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }
        
        [Display(Name = "Contact Phone")]
        public string ContactPhone { get; set; }
        
        [Display(Name = "Contact Fax")]
        public string ContactFax { get; set; }


        [Display(Name = "MC Number")]
        public string McNumber { get; set; }

        [Display(Name = "Terms and Condition")]
        public bool? AcceptTerms { get; set; }

        
        [Display(Name = "Bank Name")]
        public string BankName { get; set; }

        [Display(Name = "Account Name")]
        public string AccountName { get; set; }

        [Display(Name = "Routing Number")]
        public string RoutingNumber { get; set; }

        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }
    }
}
