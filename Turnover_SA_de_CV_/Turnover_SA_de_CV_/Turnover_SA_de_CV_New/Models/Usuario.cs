using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Turnover_SA_de_CV_.Models
{
    public class Usuario
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
}