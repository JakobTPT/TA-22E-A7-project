namespace InvoiceLine.Models
{
    public class InvoiceLine
    {
        public int Id { get; set; } // Primary Key
        public int InvoiceId { get; set; } // Foreign Key to Invoice
        public int ProductId { get; set; } // Foreign Key to Product
        public decimal UnitPrice { get; set; } // Unit price of the product
        public int Quantity { get; set; } // Quantity of the product
        public decimal Total => (UnitPrice * Quantity) - Discount + (UnitPrice * Quantity * VatRate / 100); // Calculated field
        public decimal VatRate { get; set; } // VAT rate in percentage (e.g., 10 for 10%)
        public decimal Discount { get; set; } // Discount amount applied

        // Navigation Properties
        public Invoice Invoice { get; set; } // Navigation to Invoice
        public Product Product { get; set; } // Navigation to Product
    }
}
