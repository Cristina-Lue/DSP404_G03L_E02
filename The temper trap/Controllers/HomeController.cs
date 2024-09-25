using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using The_Temper_Trap.Models;

namespace The_Temper_Trap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // GET: Home
        public IActionResult Index()
        {
            return View();
        }

        // POST: Home/Index
        [HttpPost]
        public IActionResult Index(string numeroUsuario, string contrasena, string tipoUsuario)
        {
            // Datos de usuario en memoria (quemados)
            var usuarios = new[]
            {
                new { NumeroUsuario = "cliente1", Contrasena = "password1", TipoUsuario = "Cliente" },
                new { NumeroUsuario = "empleado1", Contrasena = "password2", TipoUsuario = "Empleado" }
            };

            // Verificar las credenciales
            var usuarioValido = usuarios.FirstOrDefault(u =>
                u.NumeroUsuario == numeroUsuario &&
                u.Contrasena == contrasena &&
                u.TipoUsuario == tipoUsuario);

            if (usuarioValido != null)
            {
                // Verificar tipo de usuario y redirigir
                if (usuarioValido.TipoUsuario == "Cliente")
                {
                    // Redirige al menú del cliente
                    return RedirectToAction("ClienteMenu", "Menu", new { numeroUsuario });
                }
                else if (usuarioValido.TipoUsuario == "Empleado")
                {
                    // Redirige a la gestión de pedidos para empleados
                    return RedirectToAction("Index", "GestionPedido");
                }
            }

            // Si las credenciales no corresponden, muestra un mensaje de error
            ViewBag.Error = "Error en número de usuario o contraseña. Verifique.";
            return View();
        }

        // GET: Home/Registrarse
        public IActionResult Registrarse()
        {
            return View();
        }

        // POST: Home/Registrarse
        [HttpPost]
        public IActionResult Registrarse(string numeroUsuario, string contrasena, string tipoUsuario)
        {
            // Lógica para guardar el nuevo usuario en una base de datos
            ViewBag.MensajeRegistro = "Usuario registrado exitosamente";
            return RedirectToAction("Index");
        }

        // GET: Home/Pedido
        public IActionResult Pedido()
        {
            ViewBag.MensajePedido = "Aquí se muestran los detalles del pedido.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
