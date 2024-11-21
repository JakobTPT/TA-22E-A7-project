namespace AsixEvents.Models
{
    public class Customer
    {

        public int Id { get; set; } // Primary Key
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public decimal Discount { get; set; }


        // Navigation Property (One-to-many relationship)
        public ICollection<Invoice> Invoices { get; set; }  // Navigation to Invoices
    }
}