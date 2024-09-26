using Microsoft.AspNetCore.Mvc;

public class CarritoController : Controller
{
    [HttpPost]
    public IActionResult AgregarAlCarrito(int idProducto)
    {
        // Lógica para agregar el producto al carrito

        // Redirigir a la vista VerCarrito
        return RedirectToAction("VerCarrito", "Carrito");
    }

    public IActionResult VerCarrito()
    {
        // Lógica para obtener el carrito y pasarlo a la vista
        return View();
    }
}
