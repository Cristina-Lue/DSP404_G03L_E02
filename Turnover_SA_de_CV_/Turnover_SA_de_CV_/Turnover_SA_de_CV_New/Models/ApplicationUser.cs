using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace Turnover_SA_de_CV_.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Compras = new HashSet<Compra>();
        }

        // Propiedades adicionales para el usuario
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        // Navegación
        public virtual ICollection<Compra> Compras { get; set; }
    }
}