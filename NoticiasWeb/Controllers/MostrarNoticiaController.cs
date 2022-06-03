using Microsoft.AspNetCore.Mvc;
using NoticiasWeb.Data;
using NoticiasWeb.Models;
using NoticiasWeb.Service;
using System.Linq;


namespace NoticiasWeb.Controllers
{
    public class MostrarNoticiaController : Controller
    {
        private IMostrarNoticia _noticia;
        private readonly ILogger<MostrarNoticiaController> _logger;

        private ApplicationDBContext bd;
        private ICategoria Categorias;//inicializar el servicio de categorias

        public MostrarNoticiaController(ICategoria categorias, ILogger<MostrarNoticiaController> logger, IMostrarNoticia noticia, ApplicationDBContext _bd)
        {
            _noticia = noticia;
            _logger = logger;
            bd = _bd;
            Categorias = categorias;


        }

        public IActionResult Index()
        {

            var getInnerJoin = _noticia.GetInnerJoin().ToList();

            _ = getInnerJoin;
            ViewBag.Categorias = Categorias.Getall();


            return View(getInnerJoin);
        }
        public IActionResult categoria(int id)
        {

            var getInnerJoin = _noticia.GetInnerJoin().ToList().FindAll(x => x.CategoriaID== id);//busca las noticias segun la categoria que se escoja

            _ = getInnerJoin;
            ViewBag.Categorias = Categorias.Getall();


            return View(getInnerJoin);
        }
        public IActionResult busqueda(string q)
        {            
            return RedirectToAction("buscar", new {q= q });//recibe el parametro y lo redirige a la vista con los resultados
            }

        public IActionResult buscar(string q)
        {
            if (q == null)
            {
                q = " ";
            }
            var getInnerJoin = _noticia.GetInnerJoin().ToList().FindAll(x=>x.Titulo.Contains(q));//busca todas las noticias que tengan el texto que se busca.

            _ = getInnerJoin;
            ViewBag.Categorias = Categorias.Getall();
            ViewBag.busqueda = q;//envia lo que se busco para mantenerlo en el placeholder el input.

            return View(getInnerJoin);
        }
        public IActionResult noticia(int id)
        {

            var getInnerJoin = _noticia.GetInnerJoin().ToList().Find(x => x.NoticiaId == id);//busca todas las noticias que tengan el texto que se busca.

            _ = getInnerJoin;
            ViewBag.Categorias = Categorias.Getall();
            ViewBag.noticia = getInnerJoin;//envia la noticia a la vista
            return View();
        }



    }
}
