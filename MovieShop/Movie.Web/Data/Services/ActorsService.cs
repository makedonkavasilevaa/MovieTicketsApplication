using Microsoft.EntityFrameworkCore;
using Movie.Web.Data.Base;
using Movie.Web.Models.Domain;

namespace Movie.Web.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        private readonly ApplicationDbContext _context;

        public ActorsService(ApplicationDbContext context) : base(context) { }

       
    }
}
