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
            app.Usuarios.Add(us);
            app.SaveChanges();
            
        }

        public void DeleteUsuarios(Usuarios us)
        {
            app.Usuarios.Remove(us);
            app.SaveChanges();
            
        }

        public List<Usuarios> Getall()
        {
            return app.Usuarios.ToList();
           
        }

        public Models.Usuarios LoadInformation(Usuarios us)
        {
            var listarusuarios = app.Usuarios.Where(x => x.UsuarioId == us.UsuarioId).FirstOrDefault();
            return listarusuarios;
            
        }

        public void UpdateUsuarios(Usuarios us)
        {
            app.Usuarios.Update(us);
            app.SaveChanges();
            
        }
    }
}
