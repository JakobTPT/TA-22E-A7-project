using AsixEvents.Models;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public decimal Discount { get; set; }

    public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
