using NoticiasWeb.Service;
using NoticiasWeb.Models;
using NoticiasWeb.Data;

namespace NoticiasWeb.Repository
{
    public class Noticia : INoticia
    {
        private ApplicationDBContext app;

        public Noticia(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddNoticias(Noticias nt)
        {
            app.Noticias.Add(nt);
            app.SaveChanges();

        }

        public void DeleteNoticias(Noticias nt)
        {
            app.Noticias.Remove(nt);
            app.SaveChanges();

        }

        public List<Models.Noticias> Getall()
        {
            return app.Noticias.ToList();

        }

        public Models.Noticias LoadInformation(Noticias nt)
        {
            var listarnoticias = app.Noticias.Where(x => x.NoticiaId == nt.NoticiaId).FirstOrDefault();
            return listarnoticias;

        }

        public void UpdateNoticias(Noticias nt)
        {
            app.Noticias.Update(nt);
            app.SaveChanges();

        }
    }
}
