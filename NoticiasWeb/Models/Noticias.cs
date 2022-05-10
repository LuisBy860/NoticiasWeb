using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NoticiasWeb.Models
{
    public class Noticias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdNoticia { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public  string Imagen { get; set; }

        public DateTime fecha { get; set; }

        public int IDCategoria  { get; set; }

        public int IDUsuario { get; set; }

        public  Categorias Categoria { get; set; }

        public Usuarios Usuario { get; set; }
        
        
        public ICollection<Comentarios>  Comentarios  { get; set; }
     

    }
}
