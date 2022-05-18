using Microsoft.AspNetCore.Mvc;
using NoticiasWeb.Data;
using NoticiasWeb.Models;
using NoticiasWeb.Service;


namespace NoticiasWeb.Controllers
{
    public class MostrarNoticiaController : Controller
    {
        private IMostrarNoticia _noticia;
        private readonly ILogger<MostrarNoticiaController> _logger;

        private ApplicationDBContext bd;

        public MostrarNoticiaController(ILogger<MostrarNoticiaController> logger, IMostrarNoticia noticia, ApplicationDBContext _bd)
        {
            _noticia = noticia;
            _logger = logger;
            bd = _bd;


        }
      
            public IActionResult Index()
        {

            var getInnerJoin = _noticia.GetInnerJoin().ToList();

            _ = getInnerJoin;

    
            return View(getInnerJoin);
        }
       
    }
}
