using Microsoft.EntityFrameworkCore;
using NoticiasWeb.Data;
using NoticiasWeb.Models;
using NoticiasWeb.Service;

namespace NoticiasWeb.Repository
{
    public class MostrarNoticias: IMostrarNoticia
    {

        private ApplicationDBContext _Bd;

        public MostrarNoticias (ApplicationDBContext bd)
        {
            _Bd = bd;

        }

        public IEnumerable<Noticias> GetInnerJoin()

        {

            var join = _Bd.Noticias
                .Include(e => e.Categoria)
            .Include(e => e.Usuario).ToList();


            return join;
        }
    }
}
