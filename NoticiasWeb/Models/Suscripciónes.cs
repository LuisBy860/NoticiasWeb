using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NoticiasWeb.Models
{
    public class Suscripciónes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int SuscripcionId { get; set; }

        public int Costo { get; set; }

        public string Caracteristica { get; set; }

    public ICollection<Usuarios> Usuario { get; set; }
    }
}
