using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace plantilla.Models
{
    public class Pelicula
    {
        [Key]
        public int PeliculaId {get;set;}

        [StringLength(20)]
        [Required(ErrorMessage = "Este campo es  requerido")]
        public string Nombre { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Este campo es  requerido")]
        public string Duracion { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Este campo es  requerido")]
        public string Genero { get; set; }


        [Required(ErrorMessage = "Este campo es  requerido")]
        [DataType(DataType.Date)]
        public DateTime FechaDeEstreno { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Este campo es  requerido")]
        public string Sinopsis { get; set; }

        [Required(ErrorMessage = "Este campo es  requerido")]
        public string Protagonista { get; set; }

    }
}