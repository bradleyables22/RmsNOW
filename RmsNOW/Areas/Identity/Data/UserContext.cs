using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RmsNOW.Areas.Identity.Data;

namespace RmsNOW.Data;

public class UserContext : IdentityDbContext<User>
{
    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        this.SeedUsers(builder);
        this.SeedRoles(builder);
        this.SeedUserRoles(builder);

    }

    private void SeedUsers(ModelBuilder builder)
    {
        User user = new User()
        {
            Id = "b74ddd14-6340-4840-95c2-db12554843e1",
            UserName = "",
            Email = "",
            LockoutEnabled = false,
            PhoneNumber = ""
        };
    }
    private void SeedRoles(ModelBuilder builder)
    { 
        
    }

    private void SeedUserRoles(ModelBuilder builder)
    { 
        
    }
}
