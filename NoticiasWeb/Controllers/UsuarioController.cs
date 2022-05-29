using Microsoft.AspNetCore.Mvc;
using NoticiasWeb.Models;
using NoticiasWeb.Service;

namespace NoticiasWeb.Controllers
{
    public class UsuarioController : Controller
    {

        private IUsuario Usuario;

        public UsuarioController(IUsuario usuario)
        {
            Usuario = usuario;
        }


        public IActionResult actu(Usuarios us)
        {

            Usuario.UpdateUsuarios(us);
            return RedirectToAction("Index");

        }
        public IActionResult Guarda(Usuarios us)
        {
            //estos serian los datos por defecto en privilegios y suscripcion a la hora de registrar un usuario
            us.PrivilegioID = 1;
            us.SuscripcionID = 1;
            Usuario.AddUsuarios(us);
;
            return Redirect("Index");
        }
        public IActionResult Agregar()
        {

            return View();
        }
        public IActionResult Delete(int id)
        {
            Usuarios us = new Usuarios();
            us.UsuarioId = id;
            Usuario.DeleteUsuarios(us);

            return RedirectToAction("Index");
        }
        public IActionResult Load(int id)
        {
            Usuarios us = new();
            us.UsuarioId = id;
            var listarusuario = Usuario.LoadInformation(us);

            return View(listarusuario);
        }
        public IActionResult Index()
        {

            var listar = Usuario.Getall();

            return View(listar);
        }
        [HttpPost]
        public IActionResult Insertardata(Usuarios us)
        {

            return RedirectToAction("Index");
            // return View("Index");

        }
    }
}
