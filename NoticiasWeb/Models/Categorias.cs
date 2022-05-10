using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NoticiasWeb.Models
{
    public class Categorias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdCategoria { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public ICollection<Noticias> Noticias { get; set; }
    }
}
