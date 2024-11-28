using AsixEvents.Models;
using System;
using System.Collections.Generic;

namespace AsixEvents.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Shipping { get; set; }
        public decimal TaxRate { get; set; } //10 for 10%
        public decimal Discount { get; set; } //in currency
        public decimal GrandTotal => CalculateGrandTotal();

        public Customer Customer { get; set; }
        public ICollection<InvoiceLine> LineItems { get; set; }

        private decimal CalculateGrandTotal()
        {
            decimal taxAmount = SubTotal * TaxRate / 100;
            return SubTotal + taxAmount + Shipping - Discount;
        }
    }
}
