using Movie.Web.Data.Base;
using Movie.Web.Models.Domain;
using System;

namespace Movie.Web.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        private readonly ApplicationDbContext _context;
        public CinemasService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
