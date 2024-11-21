public class Product
{
    public int ProductId { get; set; }  // Primary Key
    public string ProductName { get; set; }
    public decimal Price { get; set; }

    // Navigation Property (One-to-many relationship)
    public ICollection<InvoiceLine> InvoiceLineItems { get; set; }  // Navigation to Invoice Line Items
}
