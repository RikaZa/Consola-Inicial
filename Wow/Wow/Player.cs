namespace Wow
{
    public class Player 
    {
        public string NombreJugador { get; set; }
        public string ApellidoJugador { get; set; }
        public string Email { get; set; }
        public string NombreCuenta { get; set; }
        public string Contraseña { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }

        public string saludoBienvenida() {
            return $"Hola bienvenido {NombreJugador}";
        }
        public string datosPlayer() {
            return $"Nombre: {NombreJugador}\n"+ $"Apellido: {NombreJugador}\n"+$"Email: {Email}\n"+ $"Nombre de cuenta: {NombreCuenta}\n"+
                $"País: {Pais}\n"+ $"Provincia: {Ciudad}\n"+ $"Ciudad: {Ciudad}\n"+ $"Edad: {Edad}\n";
        }
      
    }
    
}
