namespace NetsSharp.Models
{
    public class CardInformation
    {
        public string ExpiryDate { get; set; }
        public string Issuer { get; set; }
        public string IssuerCountry { get; set; }
        // ReSharper disable once InconsistentNaming
        public string MaskedPAN { get; set; }
        public string PaymentMethod { get; set; }
        public int IssuerId { get; set; }
    }
}