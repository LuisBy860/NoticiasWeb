using NoticiasWeb.Models;

namespace NoticiasWeb.Service
{
    public interface INoticia
    {
        public void AddNoticias(Noticias nt);
        public void UpdateNoticias(Noticias nt);
        public void DeleteNoticias(Noticias nt);
        public List<Noticias> Getall();

        public Noticias LoadInformation(Noticias nt);
    }
}



