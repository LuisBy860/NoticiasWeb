using Microsoft.AspNetCore.Mvc;
using NoticiasWeb.Models;
using NoticiasWeb.Service;


namespace NoticiasWeb.Controllers
{
    
    public class CategoriaController : Controller
    {
        private ICategoria  Categoria;

        public CategoriaController(ICategoria categoria)
        {
            Categoria = categoria;
        }

        public IActionResult actu(Categorias ca)
        {

            Categoria.UpdateCategorias(ca);
            return RedirectToAction("Index");

        }
        public IActionResult Guarda(Categorias ca)
        {
           Categoria.AddCategorias(ca);

            return Redirect("Index");
        }
        public IActionResult Agregar()
        {

            return View();
        }

        public IActionResult Delete(int id)
        {
            Categorias ca = new Categorias();
            ca.CategoriaId = id;
           Categoria.DeleteCategorias(ca);

            return RedirectToAction("Index");
        }

        public IActionResult Load(int id)
        {
            Categorias ca = new Categorias();
            ca.CategoriaId = id;
            var listarcategoria = Categoria.LoadInformation(ca);     
            return View(listarcategoria);
        }



        public IActionResult Index()
        {
         
            var listar = Categoria.Getall();
           
            return View(listar);
        }

        [HttpPost]
        public IActionResult Insertardata(Categorias ca)
        {

            return RedirectToAction("Index");
            // return View("Index");

        }
    }
}
