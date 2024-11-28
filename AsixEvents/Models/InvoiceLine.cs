namespace AsixEvents.Models
{
    public class InvoiceLine
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int? ProductId { get; set; } 
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Total => (UnitPrice * Quantity) - Discount + (UnitPrice * Quantity * VatRate / 100);
        public decimal VatRate { get; set; }
        public decimal Discount { get; set; }

        // Navigation Properties
        public Invoice Invoice { get; set; }
        public Product Product { get; set; }
    }
}
