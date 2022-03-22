using Livraria.Livros;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroService _service;

        public LivroController(ILivroService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {

            return View(_service.GetAll());
        }
    }
}
