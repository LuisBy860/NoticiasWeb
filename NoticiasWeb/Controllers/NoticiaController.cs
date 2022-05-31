using Microsoft.AspNetCore.Mvc;
using NoticiasWeb.Data;
using NoticiasWeb.Models;
using NoticiasWeb.Service;

namespace NoticiasWeb.Controllers
{
    public class NoticiaController : Controller
    {
      
        private INoticia Noticia;
        private ICategoria Categoria;//inicializar el servicio de categorias

        public NoticiaController(INoticia noticia, ICategoria categoria)
        {
            Noticia = noticia;
            Categoria = categoria;
        }


        public IActionResult actu(Noticias nt)
        {

            Noticia.UpdateNoticias(nt);
            return RedirectToAction("Index");

        }
        public IActionResult Guarda(Noticias nt)
        {
            Noticia.AddNoticias(nt);



            return Redirect("Index");
        }
        public IActionResult Agregar()
        {
            ViewBag.Categorias = Categoria.Getall();//enviando la lista de categorias el el viewbag
            return View();
        }
        public IActionResult Delete(int id)
        {
            Noticias nt = new Noticias();
            nt.NoticiaId = id;
            Noticia.DeleteNoticias(nt);

            return RedirectToAction("Index");
        }
        public IActionResult Load(int id)
        {



            Noticias nt = new();
            nt.NoticiaId = id;
            var listarnoticia = Noticia.LoadInformation(nt);

            return View(listarnoticia);

        }
        public IActionResult Index()
        {

            var listar = Noticia.Getall();


            return View(listar);
        }
        [HttpPost]
        public IActionResult Insertardata(Noticias nt)
        {

            return RedirectToAction("Index");
            // return View("Index");

        }








    }
}
