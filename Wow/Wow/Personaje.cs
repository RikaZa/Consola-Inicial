namespace Wow
{
    public class Personaje
    {
        public string NombrePersonaje{ get; set; }
        public string Faccion { get; set; }
        public string GeneroPersonaje { get; set; }
        public string Raza { get; set; }
        public string Clase { get; set; }
        public string Roll { get; set; }
        public string TipoPersonaje { get; set; }
        public string Profecion { get; set; }
        public int Nivel  { get; set; }
        public string ProfesionSecundaria { get; set; }

        public string infPersonaje() {

            return $"Nombre: {NombrePersonaje}\n" + $"Facción: {Faccion}\n" + $"Genero: {GeneroPersonaje}\n" + $"Raza: {Raza}\n" +
                $"Clase: {Clase}\n" + $"JUGADOR TIPO: {TipoPersonaje}\n" + $"Profesión: {Profecion}\n" + $"Tu comenzaste con el nivel: {Nivel}\n";

        }
    }

    
}
