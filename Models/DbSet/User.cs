using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backend.Models.DbSet;
public class User : IdentityUser<long>
{
    public Admin? Admin { get; set; }
    public Buyer? Buyer { get; set; }
}
