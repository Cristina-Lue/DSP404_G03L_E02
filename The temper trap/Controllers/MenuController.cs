using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using The_Temper_Trap.Models;

namespace The_Temper_Trap.Controllers
{
    public class MenuController : Controller
    {
        // Acción para mostrar el menú del cliente
        public IActionResult ClienteMenu(string numeroUsuario)
        {
            ViewBag.NumeroUsuario = numeroUsuario;

            // Lista con datos quemados, ahora con Cantidad
            var VerCarrito = new List<MenuItem>
            {
new MenuItem { Id = 1, Nombre = "Alitas de Pollo", Descripcion = "Alitas fritas con salsa picante o BBQ.", ImagenUrl = "https://th.bing.com/th/id/R.84553d446b0c87a5e3d0fba9062591e5?rik=oq5qwgVO7gq9WQ&pid=ImgRaw&r=0", PrecioUnitario = 10.00m, Cantidad = 1 },
new MenuItem { Id = 2, Nombre = "Ribeye a la Parrilla", Descripcion = "Corte de carne de res a la parrilla, servido con guarniciones.", ImagenUrl = "https://img.freepik.com/fotos-premium/fotografia-comida-carne-asada-verduras-asadas-estilo-cocina-lujo_873668-3876.jpg", PrecioUnitario = 18.50m, Cantidad = 1 },
new MenuItem { Id = 3, Nombre = "Tacos Veganos", Descripcion = "Tortillas rellenas de frijoles, guacamole, pico de gallo y verduras.", ImagenUrl = "https://healthysimpleyum.com/wp-content/uploads/2021/07/IMG_5042-1024x897.jpg", PrecioUnitario = 4.00m, Cantidad = 4 },
new MenuItem { Id = 4, Nombre = "Pollo al Limón", Descripcion = "Pechuga de pollo marinada y asada, servida con ensalada y arroz.", ImagenUrl = "https://th.bing.com/th/id/OIP.n1bgCC9r1Z-HtHpFol88FAHaF7?rs=1&pid=ImgDetMain", PrecioUnitario = 8.00m, Cantidad = 1 },
new MenuItem { Id = 5, Nombre = "Pasta Primavera", Descripcion = "Pasta con una mezcla de vegetales frescos y salsa de aceite de oliva.", ImagenUrl = "https://cdn.loveandlemons.com/wp-content/uploads/2022/06/pasta-primavera.jpg", PrecioUnitario = 11.99m, Cantidad = 1 },
new MenuItem { Id = 6, Nombre = "Panna Cotta", Descripcion = "Postre italiano de crema cocida, a menudo servido con salsa de frutas.", ImagenUrl = "https://i1.wp.com/www.cosiitaliano.com/wp-content/uploads/2020/06/Panna-Cotta-with-Berries-scaled.jpg?fit=2560%2C1709", PrecioUnitario = 5.00m, Cantidad = 1 },
new MenuItem { Id = 7, Nombre = "Brownie de Chocolate", Descripcion = " Pastelito denso y húmedo de chocolate.", ImagenUrl = "https://th.bing.com/th/id/OIP.o3Wd3dK0MwKmW1TOEvV3YgHaE8?rs=1&pid=ImgDetMain", PrecioUnitario = 4.75m, Cantidad = 1 },
new MenuItem { Id = 8, Nombre = "Jugo Natural", Descripcion = "Jugo elaborado de frutas de temporada.", ImagenUrl = "https://th.bing.com/th/id/OIP.j95tIwIqUur9WveOvyTD-AHaEo?rs=1&pid=ImgDetMain", PrecioUnitario = 2.50m, Cantidad = 1 },
new MenuItem { Id = 9, Nombre = "Cerveza Artesanal", Descripcion = "Cervezas locales o internacionales, con diferentes estilos y sabores.", ImagenUrl = "https://th.bing.com/th/id/R.b79d07c3e8634737b67a082cfe440626?rik=d5COwZiG39MpfA&riu=http%3a%2f%2fsevilla.abc.es%2fcontenidopromocionado%2fwp-content%2fuploads%2fsites%2f2%2f2018%2f05%2fportada-wp-artesanales.jpg&ehk=9yMxG8J011lb4E2sgplh5%2bf50oDaZcnjq4a7SInO%2b2c%3d&risl=&pid=ImgRaw&r=0", PrecioUnitario = 3.00m, Cantidad = 1 }
            };

            return View(VerCarrito);
        }
    }
}
