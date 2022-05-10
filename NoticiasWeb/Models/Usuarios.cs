using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NoticiasWeb.Models
{
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string Alias { get; set; }

        public int Contrasena { get; set; }

        public string Email { get; set; }

        public int IDPrivilegio { get; set; }

        public int IDSuscripcion { get; set; }

        public Privilegios Privilegio { get; set; }

        public Suscripciónes Suscripción { get; set; }

        public ICollection<Comentarios> Comentarios { get; set; }

        public ICollection<Noticias> Noticias { get; set; }
    }
}
