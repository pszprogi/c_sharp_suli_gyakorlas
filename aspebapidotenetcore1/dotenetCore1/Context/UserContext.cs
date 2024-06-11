using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dotenetCore1.Context
{
    public class UserContext : IdentityDbContext
    {
        public UserContext(DbContextOptions<UserContext>options) : base(options)
        {
        }
    }
}
