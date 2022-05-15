using Microsoft.AspNetCore.Mvc;
using NoticiasWeb.Models;
using NoticiasWeb.Service;


namespace NoticiasWeb.Controllers
{
    public class ComentarioController : Controller
    {
        private IComentario Comentario;

        public ComentarioController(IComentario comentario)
        {
            Comentario = comentario;
        }

        public IActionResult actu(Comentarios co)
        {

            Comentario.UpdateComentarios(co);
            return RedirectToAction("Index");

        }
        public IActionResult Guarda(Comentarios co)
        {
            Comentario.AddComentarios(co);

            return Redirect("Index");
        }
        public IActionResult Agregar()
        {

            return View();
        }

        public IActionResult Delete(int id)
        {
            Comentarios co = new Comentarios();
            co.ComentarioId = id;
            Comentario.DeleteComentarios(co);

            return RedirectToAction("Index");
        }

        public IActionResult Load(int id)
        {
            Comentarios co = new Comentarios();
            co.ComentarioId = id;
            var listarcomentario = Comentario.LoadInformation(co);

            return View(listarcomentario);
        }



        public IActionResult Index()
        {

            var listar = Comentario.Getall();

            return View(listar);
        }
        [HttpPost]
        public IActionResult Insertardata(Comentarios ca)
        {

            return RedirectToAction("Index");
            // return View("Index");

        }
    }
}

