public class Invoice
{
    public int Id { get; set; }  // Primary Key
    public int InvoiceNo { get; set; } // Foreign Key to Customer
    public DateTime InvoiceDate { get; set; }
    public DateTime DueDate { get; set; }
    public decimal SubTotal { get; set; }
    public decimal Shipping { get; set; }
    public decimal GrandTotal { get; set; }

    // Navigation Property (One-to-many relationship)
    public Customer Customer { get; set; }  // Navigation to Customer
    public ICollection<InvoiceLine> LineItems { get; set; }  // Navigation to Invoice Line Items
}
