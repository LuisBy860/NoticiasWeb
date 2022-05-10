﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoticiasWeb.Models
{
    public class Comentarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ComentarioId { get; set; }

        public string Comentario { get; set; }

        public DateTime Fecha { get; set; }

        public int NoticiaID { get; set; }

      

        //tablas con las que tiene relacion 
         public Noticias Noticia { get; set; }

    
    }
}
