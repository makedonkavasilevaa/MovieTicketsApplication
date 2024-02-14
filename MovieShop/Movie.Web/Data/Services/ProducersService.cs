using Movie.Web.Data.Base;
using Movie.Web.Models.Domain;

namespace Movie.Web.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(ApplicationDbContext context) : base(context) { }
        
    }
}
