using NoticiasWeb.Data;
using NoticiasWeb.Models;
using NoticiasWeb.Service;

namespace NoticiasWeb.Repository
{
    public class Comentarios : IComentario
    {
        private ApplicationDBContext app;

        public Comentarios(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddComentarios(Models.Comentarios co)
        {
            app.Comentarios.Add(co);
            app.SaveChanges();
        }

        public void DeleteComentarios(Models.Comentarios co)
        {
            app.Comentarios.Remove(co);
            app.SaveChanges();
        }

        public List<Models.Comentarios> Getall()
        {
            return app.Comentarios.ToList();
        }

        public Models.Comentarios LoadInformation(Models.Comentarios co)
        {
            var listarcomentario = app.Comentarios.Where(x => x.ComentarioId == co.ComentarioId).FirstOrDefault();
            return listarcomentario;
        }

        public void UpdateComentarios(Models.Comentarios co)
        {
            app.Comentarios.Update(co);
            app.SaveChanges();
        }
    }
}
