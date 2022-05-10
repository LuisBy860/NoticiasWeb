using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NoticiasWeb.Models
{
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int UsuarioId { get; set; }

        public string Nombre { get; set; }

        public string Alias { get; set; }

        public int Contrasena { get; set; }

        public string Email { get; set; }

        public int PrivilegioID { get; set; }

        public int SuscripcionID { get; set; }

        public Privilegios Privilegio { get; set; }

        public Suscripciónes Suscripcion { get; set; }

      

        public ICollection<Noticias> Noticia { get; set; }
    }
}
