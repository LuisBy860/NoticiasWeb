using NoticiasWeb.Models;

namespace NoticiasWeb.Service
{
    public interface IPrivilegio
    {
        public void AddPrivilegios(Privilegios pv);
        public void UpdatePrivilegios(Privilegios pv);
        public void DeletePrivilegios(Privilegios pv);
        public List<Privilegios> Getall();

        public Privilegios LoadInformation(Privilegios pv);
    }
}
