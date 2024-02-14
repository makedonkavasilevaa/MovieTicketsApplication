using Microsoft.AspNetCore.Mvc;
using Movie.Web.Data;
using Movie.Web.Data.Services;

namespace Movie.Web.Controllers
{
    public class ActorsController : Controller
    {

        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data =await  _service.GetAll();
            return View(data);
        }

        //GET: Actors/Create
        public IActorsService Create()
        {
            return View();
        }
    }
}
