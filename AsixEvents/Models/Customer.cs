using InvoiceLine.Models;
using System.Collections.Generic;

namespace AsixEvents.Models
{
    public class Customer
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } // Customer name
        public string Address { get; set; } // Customer address
        public string Email { get; set; } // Customer email
        public string Phone { get; set; } // Changed to string to support phone number formats
        public decimal Discount { get; set; } // Discount applied to the customer

        // Navigation Property (One-to-many relationship)
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>(); // Navigation to Invoices
    }
}
