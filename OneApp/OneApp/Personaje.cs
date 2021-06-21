namespace OneApp
{
    public class Personaje {
        public string NombrePJ { get; set; }
        public string Faccion { get; set; }
        public string Raza { get; set; }
        public string Clase { get; set; }
        public string Talento { get; set; }
        public string ModoJuego { get; set; }
        public int  Nivel { get; set; }
        public string Profecion { get; set; }
        public string ProfecionSecundaria { get; set; }

        public string dataPersonaje() {
            return $"Nombre de personaje: {NombrePJ}\nFacción: {Faccion}\nRaza: {Raza}\nClase: {Clase}\nTalento: {Talento}\nModo de juego: {ModoJuego}\n Nivel:{Nivel}\nProfesión: {Profecion}\nProfesión Secundaria: {ProfecionSecundaria}";
        }


    }
}
