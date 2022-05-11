using Microsoft.AspNetCore.Mvc;
using NoticiasWeb.Models;
using NoticiasWeb.Service;

namespace NoticiasWeb.Controllers
{
    public class PrivilegioController : Controller
    {
        private IPrivilegio Privilegio;

        public PrivilegioController(IPrivilegio privilegio)
        {
            Privilegio = privilegio;
        }

        public IActionResult actu(Privilegios pv)
        {

            Privilegio.UpdatePrivilegios(pv);
            return RedirectToAction("Index");

        }
        public IActionResult Guarda(Privilegios pv)
        {
            Privilegio.AddPrivilegios(pv);

            return Redirect("Index");
        }
        public IActionResult Agregar()
        {

            return View();
        }

        public IActionResult Delete(int id)
        {
            Privilegios pv = new Privilegios();
            pv.PrivilegioId = id;
            Privilegio.DeletePrivilegios(pv);

            return RedirectToAction("Index");
        }

        public IActionResult Load(int id)
        {
            Privilegios pv = new Privilegios();
            pv.PrivilegioId = id;
            var listarprivilegios = Privilegio.LoadInformation(pv);

            return View(listarprivilegios);
        }

        public IActionResult Index()
        {

            var listar = Privilegio.Getall();

            return View(listar);
        }

        [HttpPost]
        public IActionResult Insertardata(Privilegios pv)
        {

            return RedirectToAction("Index");
            // return View("Index");

        }

    }
}
