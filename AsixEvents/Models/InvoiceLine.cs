public class InvoiceLine
{
    public int Id { get; set; } // Primary Key
    public int LineItem { get; set; }  // Foreign Key to Invoice
    public int UnitPrice { get; set; }  // Foreign Key to Product
    public int Total { get; set; }
    public int Quantity { get; set; }
    public decimal VatRate { get; set; }
    public decimal Discount { get; set; }

    // Navigation Properties
    public Invoice Invoice { get; set; }  // Navigation to Invoice
    public Product Product { get; set; }  // Navigation to Product
}
