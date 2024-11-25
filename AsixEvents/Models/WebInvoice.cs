using System;
using System.Collections.Generic;

namespace WebInvoice.Models
{
    // Represents a customer (e.g., "To" section in the invoice)
    public class Customer
    {
        public int CustomerId { get; set; } // Primary Key
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    // Represents the invoice
    public class Invoice    
    {
        public int InvoiceId { get; set; } // Primary Key
        public string InvoiceNumber { get; set; } // e.g., EWD0015688
        public DateTime InvoiceDate { get; set; } // Invoice date
        public DateTime DueDate { get; set; } // Optional, for payment terms
        public Customer CustomerDetails { get; set; } // Navigation to Customer (e.g., "To")
        public Customer CompanyDetails { get; set; } // Navigation to Company (e.g., "From")

        // Financial Details
        public decimal SubTotal { get; set; }
        public decimal TaxRate { get; set; } // e.g., 10%
        public decimal Discount { get; set; } // e.g., 5%
        public decimal ShippingCost { get; set; }
        public decimal GrandTotal => CalculateGrandTotal(); // Computed property

        // List of invoice line items
        public ICollection<InvoiceLine> LineItems { get; set; } = new List<InvoiceLine>();

        // Payment Methods
        public ICollection<PaymentMethod> PaymentMethods { get; set; } = new List<PaymentMethod>();

        // Compute the grand total dynamically
        private decimal CalculateGrandTotal()
        {
            decimal taxAmount = SubTotal * TaxRate / 100;
            decimal discountAmount = SubTotal * Discount / 100;
            return SubTotal + taxAmount - discountAmount + ShippingCost;
        }
    }

    // Represents each line item in the invoice
    public class InvoiceLine
    {
        public int LineId { get; set; } // Primary Key
        public string Description { get; set; } // Item description
        public decimal UnitPrice { get; set; } // Price per unit
        public int Quantity { get; set; } // Quantity of the item
        public decimal Total => UnitPrice * Quantity; // Total price for the line item
    }

    // Represents available payment methods
    public class PaymentMethod
    {
        public int PaymentMethodId { get; set; } // Primary Key
        public string MethodName { get; set; } // e.g., "PayPal", "Wire", "Credit Card", etc.
    }
}
