using System.ComponentModel.DataAnnotations.Schema;


namespace backend.Models.DbSet;
public class Buyer
{
    public long ID { get; set; }
    public long? UserID { get; set; }
    public string FirstName { get; set; } = String.Empty;
    public string? Surname { get; set; } = null;
    public string? PhoneNumber { get; set; } = null;
    public User? User { get; set; } = new User();

}

