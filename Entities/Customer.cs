namespace ClienteBanco.Entities;

public class Customer
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? CompanyName { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? State { get; set; } = string.Empty;
    public string? Zip { get; set; }
    public string? Phone1 { get; set; }
    public string? Phone2 { get; set; }
    public string? Email { get; set; }
    public string? Web { get; set; }
    public string? Type { get; set; }
    public string? Balance { get; set; }
}
