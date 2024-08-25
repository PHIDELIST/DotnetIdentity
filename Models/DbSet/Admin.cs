using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.DbSet;

public class Admin
{
    public long ID { get; set; }
    public Guid AdminID { get; set; }
    public long UserID { get; set; }
    public string FirstName { get; set; } = String.Empty;
    #nullable enable
    public string Surname { get; set; } = String.Empty;
    public string PhoneNumber { get; set; } = String.Empty;
    public User User {get;set;} = new User();

}
