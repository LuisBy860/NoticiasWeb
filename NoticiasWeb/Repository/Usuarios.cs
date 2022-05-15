using NoticiasWeb.Service;
using NoticiasWeb.Models;
using NoticiasWeb.Data;

namespace NoticiasWeb.Repository
{
    public class Usuario : IUsuario
    {
        private ApplicationDBContext app;

        public Usuario(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddUsuarios(Usuarios us)
        {
            throw new NotImplementedException();
        }

        public void DeleteUsuarios(Usuarios us)
        {
            throw new NotImplementedException();
        }

        public List<Models.Usuarios> Getall()
        {
            throw new NotImplementedException();
        }

        public Models.Usuarios LoadInformation(Usuarios us)
        {
            throw new NotImplementedException();
        }

        public void UpdateUsuarios(Usuarios us)
        {
            throw new NotImplementedException();
        }
    }
}
