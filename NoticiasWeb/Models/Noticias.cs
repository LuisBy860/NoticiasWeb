using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NoticiasWeb.Models
{
    public class Noticias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int NoticiaId { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public  string Imagen { get; set; }

        public DateTime fecha { get; set; }

        public int CategoriaID { get; set; }

        public int UsuarioID { get; set; }

        public  Categorias Categoria { get; set; }

        public Usuarios Usuario { get; set; }


        public ICollection<Comentarios> Comentario { get; set; }


    }
}
