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



        public void AddCategorias(Categorias ca)
        {

            app.Categorias.Add(ca);
            app.SaveChanges();

            
        }

        public void DeleteCategorias(Categorias ca)
        {
            app.Categorias.Remove(ca);
            app.SaveChanges();
        }

        public List<Categorias> Getall()
        {
            return app.Categorias.ToList();
        }

        public Categorias LoadInformation(Categorias ca)
        {
            var listarcategoria = app.Categorias.Where(x => x.CategoriaId == ca.CategoriaId).FirstOrDefault();
            return listarcategoria;
        }

        public void UpdateCategorias(Categorias ca)
        {
            app.Categorias.Update(ca);
            app.SaveChanges();
        }
    }
}
