using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Movie.Web.Models.Identity;

namespace Movie.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<MovieAppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
