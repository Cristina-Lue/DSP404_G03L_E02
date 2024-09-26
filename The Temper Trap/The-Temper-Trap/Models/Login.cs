namespace The_Temper_Trap.Models
{
    public class Login
    {
        public string NumeroUsuario { get; private set; }
        public string Contrasena { get; private set; }
        public string TipoUsuario { get; private set; }

        private static List<Login> UsuariosRegistrados = new List<Login>();

        public Login(string numeroUsuario, string contrasena, string tipoUsuario)
        {
            NumeroUsuario = numeroUsuario;
            Contrasena = contrasena;
            TipoUsuario = tipoUsuario;
        }

        public bool VerificarLogin(string numeroUsuarioIngresado, string contrasenaIngresada, string tipoUsuarioIngresado)
        {
            return NumeroUsuario == numeroUsuarioIngresado &&
                   Contrasena == contrasenaIngresada &&
                   TipoUsuario == tipoUsuarioIngresado;
        }

        public string IniciarSesion(string numeroUsuarioIngresado, string contrasenaIngresada, string tipoUsuarioIngresado)
        {
            if (VerificarLogin(numeroUsuarioIngresado, contrasenaIngresada, tipoUsuarioIngresado))
            {
                return "Login exitoso.";
            }
            return "Error: Credenciales incorrectas.";
        }

        public static string RegistrarUsuario(string numeroUsuario, string contrasena, string tipoUsuario)
        {
            if (UsuariosRegistrados.Any(u => u.NumeroUsuario == numeroUsuario))
            {
                return "Error: El usuario ya está registrado.";
            }

            UsuariosRegistrados.Add(new Login(numeroUsuario, contrasena, tipoUsuario));
            return "Registro exitoso. Ahora puedes iniciar sesión.";
        }

        public static bool UsuarioYaRegistrado(string numeroUsuario)
        {
            return UsuariosRegistrados.Any(u => u.NumeroUsuario == numeroUsuario);
        }
    }
}
