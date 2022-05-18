using NoticiasWeb.Models;

namespace NoticiasWeb.Service

{
    public interface IMostrarNoticia
    {

        IEnumerable<Noticias> GetInnerJoin();
    }
}
