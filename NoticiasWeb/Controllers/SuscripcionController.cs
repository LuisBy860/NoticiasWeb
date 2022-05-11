using NoticiasWeb.Data;
using NoticiasWeb.Models;
using NoticiasWeb.Service;

using Microsoft.AspNetCore.Mvc;
using NoticiasWeb.Repository;

namespace NoticiasWeb.Controllers
{
    public class SuscripcionController : Controller
    {
        private ISuscripcion Suscripcion;

        public SuscripcionController(ISuscripcion suscripcion)
        {
            Suscripcion = suscripcion;
        }

      
        public IActionResult actu(Models.Suscripciónes su)
        {

            Suscripcion.UpdateSuscripciones(su);
            return RedirectToAction("Index");

        }
        public IActionResult Guarda(Models.Suscripciónes su)
        {
            Suscripcion.AddSuscripciones(su);

            return Redirect("Index");
        }
        public IActionResult Agregar()
        {

            return View();
        }
        public IActionResult Delete(int id)
        {
            Suscripciónes su = new Suscripciónes();
            su.SuscripcionId = id;
            Suscripcion.DeleteSuscripciones(su);

            return RedirectToAction("Index");
        }
        public IActionResult Load(int id)
        {
            Suscripciónes su = new Suscripciónes();
            su.SuscripcionId = id;
            var listarsuscripcion = Suscripcion.LoadInformation(su);

            return View(listarsuscripcion);
        }
        public IActionResult Index()
        {

            var listar = Suscripcion.Getall();

            return View(listar);
        }
        [HttpPost]
        public IActionResult Insertardata(Suscripciónes ca)
        {

            return RedirectToAction("Index");
            // return View("Index");

        }
    }
}
