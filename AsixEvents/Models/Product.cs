using System.Collections.Generic;

namespace InvoiceLine.Models
{
    public class Product
    {
        public int ProductId { get; set; } // Primary Key
        public string ProductName { get; set; } // Name of the product
        public string ProductDescription { get; set; } // Optional description for the product
        public decimal Price { get; set; } // Price of the product

        // Navigation Property (One-to-many relationship)
        public ICollection<InvoiceLine> InvoiceLineItems { get; set; } = new List<InvoiceLine>(); // Navigation to Invoice Line Items
    }
}
