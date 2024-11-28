﻿using System.Collections.Generic;

namespace AsixEvents.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }

        public ICollection<InvoiceLine> InvoiceLineItems { get; set; } = new List<InvoiceLine>();
    }
}
