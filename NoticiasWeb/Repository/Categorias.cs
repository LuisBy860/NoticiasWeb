using NoticiasWeb.Data;
using NoticiasWeb.Models;
using NoticiasWeb.Service;

namespace NoticiasWeb.Repository
{
    public class Categoria : ICategoria
    {
        private ApplicationDBContext app;

        public Categoria(ApplicationDBContext app)
        {
            this.app = app;
        }



        public void AddCategorias(Models.Categorias ca)
        {

            app.Categorias.Add(ca);
            app.SaveChanges();

            
        }

        public void DeleteCategorias(Models.Categorias ca)
        {
            app.Categorias.Remove(ca);
            app.SaveChanges();
        }

        public List<Models.Categorias> Getall()
        {
            return app.Categorias.ToList();
        }

        public Models.Categorias LoadInformation(Models.Categorias ca)
        {
            var listarcategoria = app.Categorias.Where(x => x.CategoriaId == ca.CategoriaId).FirstOrDefault();
            return listarcategoria;
        }

        public void UpdateCategorias(Models.Categorias ca)
        {
            app.Categorias.Update(ca);
            app.SaveChanges();
        }
    }
}
