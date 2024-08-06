using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JWT_Token_Authentication.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>//It is inheriting from Identitydbcontext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        
        
        }

        


    }
}
