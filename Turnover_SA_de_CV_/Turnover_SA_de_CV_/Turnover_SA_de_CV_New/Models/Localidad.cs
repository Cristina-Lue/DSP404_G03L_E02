using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Turnover_SA_de_CV_.Models
{
    [Table("Localidades")] // Vincula el modelo a la tabla "Localidades"
    public class Localidad
    {
        [Key]
        public int UsuarioID { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public string Correo { get; set; }
        [Required]
        [StringLength(100)]
        public string Contrasena { get; set; }
    }

    // Relación con la tabla Concierto
    public Concierto Concierto { get; set; }
    }

}