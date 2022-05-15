using NoticiasWeb.Models;

namespace NoticiasWeb.Service
{
    public interface IUsuario
    {
        public void AddUsuarios(Usuarios us);
        public void UpdateUsuarios(Usuarios us);
        public void DeleteUsuarios(Usuarios us);
        public List<Usuarios> Getall();

        public Usuarios LoadInformation(Usuarios us);
    }
}
