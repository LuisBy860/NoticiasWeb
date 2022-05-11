using NoticiasWeb.Data;
using NoticiasWeb.Models;
using NoticiasWeb.Service;

namespace NoticiasWeb.Repository
{
    public class Suscripciones : ISuscripcion
    {
        private ApplicationDBContext app;

        public Suscripciones (ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddSuscripciones(Suscripciónes ca)
        {
            app.Suscripciónes.Add(ca);
            app.SaveChanges();
        }

        public void DeleteSuscripciones(Suscripciónes ca)
        {

            app.Suscripciónes.Remove(ca);
            app.SaveChanges();
        }

        public List<Suscripciónes> Getall()
        {
            return app.Suscripciónes.ToList();
        }

        public Suscripciónes LoadInformation(Suscripciónes ca)
        {
            var listarsuscripcion = app.Suscripciónes.Where(x => x.SuscripcionId == ca.SuscripcionId).FirstOrDefault();
            return listarsuscripcion;
        }

        public void UpdateSuscripciones(Suscripciónes ca)
        {
            app.Suscripciónes.Update(ca);
            app.SaveChanges();
        }
    }
}
