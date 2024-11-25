using AsixEvents.Models;
using System;
using System.Collections.Generic;

namespace InvoiceLine.Models
{
    public class Invoice
    {
        public int Id { get; set; } // Primary Key
        public string InvoiceNo { get; set; } // Unique invoice number (changed to string for flexibility)
        public DateTime InvoiceDate { get; set; } // Date when the invoice was created
        public DateTime DueDate { get; set; } // Date by which the payment is due
        public decimal SubTotal { get; set; } // Sum of line items before additional charges
        public decimal Shipping { get; set; } // Shipping costs
        public decimal TaxRate { get; set; } // Tax rate applied to the invoice (e.g., 10 for 10%)
        public decimal Discount { get; set; } // Discount applied to the invoice
        public decimal GrandTotal => CalculateGrandTotal(); // Computed property for the grand total

        // Navigation Properties
        public Customer Customer { get; set; } // Navigation to Customer (one-to-many relationship)
        public ICollection<InvoiceLine> LineItems { get; set; } // Navigation to invoice line items

        // Private method to calculate the grand total
        private decimal CalculateGrandTotal()
        {
            decimal taxAmount = SubTotal * TaxRate / 100;
            return SubTotal + taxAmount + Shipping - Discount;
        }
    }
}
