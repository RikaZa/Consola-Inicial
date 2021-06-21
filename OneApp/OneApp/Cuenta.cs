namespace OneApp
{
    public class Cuenta 
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCuenta { get; set; }
        public string Pais { get; set; }
        public string Genero { get; set; }
        public string Faccion { get; set; }
        public string Clave { get; set; }
        public int Edad { get; set; }
        public string Ciudad { get; set; }

        public string mensajeBienvenida() {

            return $"Bienvenido {Nombre}\nHas creado la cuenta {NombreCuenta} con exito...\nAhora eres un parte de la {Faccion}";
        }
        public string datosCuenta (){
            return $"Nombre: {Nombre}\nApellido: {Apellido}\nCuenta: {NombreCuenta}\nDirección: {Pais} - {Ciudad}\nEdad: {Edad} ";
        }
    }
}
