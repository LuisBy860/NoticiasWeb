using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NoticiasWeb.Models
{
    public class Privilegios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdPrivilegio { get; set; }

        public string TipoUsuario { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
