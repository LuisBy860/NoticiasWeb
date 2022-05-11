using NoticiasWeb.Models;

namespace NoticiasWeb.Service
{
    public interface ICategoria
    {
        public void AddCategorias(Categorias ca);
        public void UpdateCategorias(Categorias ca);
        public void DeleteCategorias(Categorias ca);
        public List<Categorias> Getall();

        public Categorias LoadInformation(Categorias ca);

    }
}
