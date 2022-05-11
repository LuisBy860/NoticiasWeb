using NoticiasWeb.Data;
using NoticiasWeb.Models;
using NoticiasWeb.Service;

namespace NoticiasWeb.Repository
{
    public class Privilegio : IPrivilegio
    {
        private ApplicationDBContext app;

        public Privilegio(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddPrivilegios(Models.Privilegios pv)
        {
            app.Privilegios.Add(pv);
            app.SaveChanges();
        }

        public void DeletePrivilegios(Models.Privilegios pv)
        {
            app.Privilegios.Remove(pv);
            app.SaveChanges();
        }

        public List<Models.Privilegios> Getall()
        {
            return app.Privilegios.ToList();
        }

        public Models.Privilegios LoadInformation(Models.Privilegios pv)
        {
            var listarprivilegios = app.Privilegios.Where(x => x.PrivilegioId == pv.PrivilegioId).FirstOrDefault();
            return listarprivilegios;
        }

        public void UpdatePrivilegios(Models.Privilegios pv)
        {
            app.Privilegios.Update(pv);
            app.SaveChanges();
        }
    }
}
