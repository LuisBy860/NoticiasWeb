using NoticiasWeb.Models;

namespace NoticiasWeb.Service
{
    public interface IComentario
    {
        public void AddComentarios(Comentarios co);
        public void UpdateComentarios(Comentarios co);
        public void DeleteComentarios(Comentarios co);
        public List<Comentarios> Getall();

        public Comentarios LoadInformation(Comentarios co);

    }
}
