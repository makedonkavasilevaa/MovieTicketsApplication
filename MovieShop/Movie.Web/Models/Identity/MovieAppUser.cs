using Microsoft.AspNetCore.Identity;

namespace Movie.Web.Models.Identity
{
    public class MovieAppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }

        

    }
}
