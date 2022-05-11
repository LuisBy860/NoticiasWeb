using NoticiasWeb.Models;

namespace NoticiasWeb.Service
{
    public interface ISuscripcion
    {
        public void AddSuscripciones(Suscripciónes ca);
        public void UpdateSuscripciones(Suscripciónes ca);
        public void DeleteSuscripciones(Suscripciónes ca);
        public List<Suscripciónes> Getall();

        public Suscripciónes LoadInformation(Suscripciónes ca);
    }
}
