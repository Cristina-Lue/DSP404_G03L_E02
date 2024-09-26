using Microsoft.AspNetCore.Mvc;

namespace The_Temper_Trap.Controllers
{
    public class GestionPedidoController : Controller
    {
        public IActionResult Index()
        {
            // Simulación de pedidos (en un entorno real, deberías obtenerlos de la base de datos)
            var pedidos = new[]
            {
                new { Id = 1, Producto = "Pizza Margarita", Cantidad = 2, Estado = "En preparación" },
                new { Id = 2, Producto = "Sushi variado", Cantidad = 1, Estado = "Listo" },
            };

            return View(pedidos);
        }

        // Método opcional para actualizar el estado del pedido
        public IActionResult ActualizarEstado(int id)
        {
            // Aquí puedes implementar la lógica para actualizar el estado del pedido
            ViewBag.MensajeActualizacion = "Estado del pedido actualizado exitosamente.";
            return RedirectToAction("Index");
        }
    }
}
