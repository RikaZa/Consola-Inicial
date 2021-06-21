using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneApp
{
    public class Arma{
        public string TipoArma;
        public string CombateArma;
        public string NombreArma;
        public int Daño;
        public int Durabilidad;
        public int IndiceGolpe;
        public int IndiceCritico;
        public int Esquivar;
        public int Defensa;
        public int Fuerza;
        
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            string nombre, apellido, nombreCuenta, pais, genero, faccion, clave, ciudad;
            int edad;
            bool inicio;
            
            Console.WriteLine("***************** | BIENVENIDO a World of Warcraft | ***************** ");
            Console.WriteLine("¿Deseas jugar?");
            Console.WriteLine("SI = 1\nNO = 0");
            int star = int.Parse(Console.ReadLine());
            if (star == 1)
            {
                Console.Clear();
                Console.WriteLine("PARA JUGAR DEBES CREAR TU CUENTA:\n-------------------------------\n");
                inicio = true;
            }
            else
            {
              
                inicio = false;

            }

            if (inicio == true)
            {
                Console.WriteLine("Ingresa tu nombre:");
            }
            else {
                Console.WriteLine("ADIOS!!");
                Console.WriteLine("Que te vaya bien colega!!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            // *************** Registrar Cuenta ************************
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingresa nombre de la cuenta:");
            nombreCuenta = Console.ReadLine();
            Console.WriteLine("Ingresa tu contraseña:");
            clave = Console.ReadLine();
            Console.WriteLine("Ingresa tu país:");
            pais = Console.ReadLine();
            Console.WriteLine("Ingresa si eres M/F:");
            genero = Console.ReadLine();
            if (genero == "M" | genero == "F" | genero == "m" | genero == "f")
            {
                Console.WriteLine("Ingresa si eres horda o alianza:");
            }
            else { 
                Console.Clear();
                Console.WriteLine("Ingresaste un dato incorrecto!!");
            }
            faccion = Console.ReadLine();
            if (faccion == "horda" | faccion == "alianza") {
                Console.WriteLine("Ingresa tu ciudad:");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ingresaste un dato incorrecto!!");
                Environment.Exit(0);
            }
            ciudad = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad:");
            edad = int.Parse(Console.ReadLine());
           

            var nuevaCuenta = new Cuenta
            {
                Nombre = nombre,
                Apellido = apellido,
                NombreCuenta = nombreCuenta,
                Pais = pais,
                Genero = genero,
                Faccion = faccion,
                Clave = clave,
                Edad = edad,
                Ciudad = ciudad,
            };

            Console.Clear();
            Console.WriteLine("1 = Crear Personaje.\n2 = Información de la cuenta.");
            int numRespuesta = int.Parse( Console.ReadLine());
            if (faccion == "horda" | faccion == "Horda" | faccion == "Horda")
            {
                Console.WriteLine("Tu elegiste ser de la HORDA!");
                Console.ReadKey();
            }
            if (faccion == "alianza" | faccion == "ALIANZA" | faccion == "Alianza")
            {
                Console.WriteLine("Tu elegiste ser de la ALIANZA!");
                Console.ReadKey();
            }

            if (numRespuesta == 1)
            {
                string nombrePj, raza, clase, talento, modoJuego, profesion, profesionSecundaria;
                int nivel;
                Console.Clear();
               
                Console.WriteLine("Ingresa el nombre de tu personaje:");
                nombrePj = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Elige tu raza:\n1 = Humano\n2 = Horco\n3 = Enano\n4 = Elfo de Sangre");
                raza = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Elige tu clase:\n1 = Guerrero\n2 = Paladin\n3 = Brujo\n4 = Caballero de la muerte");
                clase = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Elige tu clase:\n1 = DPS\n2 = HELER\n3 = TANQUE");
                talento = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Elige tu modo de juego:\n1 = PVP\n2 = PVP");
                modoJuego = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Elige tu profesión:\n1 = INGENIERO\n2 = HERRERO\n3 = ALQUIMISTA\n4 = MINERO");
                profesion = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Elige tu profesión secundaria:\n1 = COCINERO\n2 = PRIMEROS AUXILIOS");
                profesionSecundaria = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("ELIGE UN NIVEL DEL 1 AL 80");
                nivel = int.Parse( Console.ReadLine());
                Console.Clear();

                var nuevoPersonaje = new Personaje
                {
                    NombrePJ = nombrePj,
                    Faccion = faccion,
                    Raza = raza,
                    Clase = clase,
                    Talento = talento,
                    ModoJuego = modoJuego,
                    Profecion = profesion,
                    ProfecionSecundaria = profesionSecundaria,
                    Nivel = nivel
                };
            }if (numRespuesta == 2) {
                Console.Clear();
                Console.WriteLine(nuevaCuenta.datosCuenta());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Muchas gracias por participar");
                Console.ReadKey();
                Environment.Exit(0);
            }

        }
    }
}
