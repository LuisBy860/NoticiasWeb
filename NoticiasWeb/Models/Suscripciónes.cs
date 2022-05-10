using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NoticiasWeb.Models
{
    public class Suscripciónes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdSuscripcion { get; set; }

        public int Costo { get; set; }

        public string Caracteristica { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
