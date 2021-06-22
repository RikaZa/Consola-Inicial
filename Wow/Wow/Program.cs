using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wow
{
    class Program
    {
        static void Main(string[] args)
        {
            int iniciar;
          
            
            Console.WriteLine("************* BIENVENIDO A MI PRIMER PROGRAMA EN C# ************** "+"\n");
            Console.WriteLine("¿Quieres iniciar el juego?"+"\n" + "\n1 = SI\n2 = NO");
            iniciar = int.Parse( Console.ReadLine());

            if (iniciar == 1 | iniciar != 1)
            {
                Console.Clear();
            }
            else {
                Console.Clear();
                Console.WriteLine("Hasta luego amigo!!");
                Console.ReadKey();
                Environment.Exit(0);
            }



            // ***************** DEFINIR VARIABLES DE Player *****************

            string nombreJugador,apellidoJugador,nombreCuenta,contraseña,pais,provincia,ciudad,genero,email;
            int edad;

            // ASIGNAR DATOS DE VARIABLE
            Console.WriteLine("Ingresa tu nombre:");
            nombreJugador = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingresa tu apellido:");
            apellidoJugador = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingresa tu correo electrónico:");
            email = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingresa el nombre de tu cuenta:");
            nombreCuenta = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingresa tu contraseña:");
            contraseña = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingresa tu país:");
            pais = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingresa tu provincia:");
            provincia = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingresa tu ciudad:");
            ciudad = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingresa tu edad:");
            edad = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ingresa tu género M/F:");
            genero = Console.ReadLine();
            Console.WriteLine("Gracias por registrate");
            Console.ReadKey();

            // DATOS DE PLAYER 

            var nuevoPlayer = new Player
            {  
                NombreJugador = nombreJugador,
                ApellidoJugador = apellidoJugador,
                Email = email,
                NombreCuenta = nombreCuenta,
                Contraseña = contraseña,
                Pais = pais,
                Provincia = provincia,
                Ciudad = ciudad,
                Edad = edad,
                Genero = genero
            };
            Console.Clear();
            Console.WriteLine(nuevoPlayer.saludoBienvenida());
            Console.WriteLine("\nMENÚ DE JUGADOR" + "\n" + "\n1 = Información de Juegador\n2 = Crear Personaje\n3 = JUGAR");
            int option = int.Parse(Console.ReadLine());

            if (option == 1) {
                Console.WriteLine(nuevoPlayer.datosPlayer());
                Console.ReadKey();
            }
            if( option == 2)
            {
                Console.Clear();
            }
            if (option == 3) {

                Console.Clear();
            }
            
            //***************** DEFINIR VARIABLES DE PERSONAJE *********************

            string nombrePersonaje, faccion, generoPersonaje, raza, clase, roll, tipoPersonaje, profecion, profesionSecundaria;
            int nivel;

            // ASIGANAR DATOS VARIABLES PERSONAJE

            Console.WriteLine("Ingresa el nombre de tu personaje:");
            nombrePersonaje = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Elige tu Facción:\n"+ "\n1 = HORDA\n2 = ALIANZA");
            faccion = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Elige tu genero:\n" + "\n1 = HOMBRE\n2 = MUJER");
            generoPersonaje = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Elige tu RAZA:\n" + "\n1 = HUMANO\n2 = HORCO");
            raza = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Elige tu RAZA:\n" + "\n1 = PALADIN\n2 = GERRERO");
            clase = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Elige tu RAZA:\n" + "\n1 = DPS\n2 = HELER\n3 = TANQUE");
            roll = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("ELIGE:\n" + "\n1 = CASTER\n2 = MELE");
            tipoPersonaje = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Elige tu profesión:\n" + "\n1 = INGENIERO\n2 = HERRERO\n3 = ALQUIMISTA");
            profecion = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Elige tu profesión secundaria:\n" + "\n1 = COCINERO\n2 = MINERO\n3 = TALADOR");
            profesionSecundaria = Console.ReadLine();
            Console.Clear();
            nivel = 1;
            

            // DATOS DE PERSONAJE 

            var nuevoPersonaje = new Personaje
            {
                NombrePersonaje = nombrePersonaje,
                Faccion = faccion,
                GeneroPersonaje = generoPersonaje,
                Raza = raza,
                Clase = clase,
                Roll = roll,
                TipoPersonaje = tipoPersonaje,
                Profecion = profecion,
                Nivel = nivel,
                ProfesionSecundaria = profesionSecundaria

            };

            //***************** DEFINIR VARIABLES DE ARMAS *********************

            string nombreArma, estiloArma;
            int aguante, armadura, golpeCritico, daño, penetracionArmadura, penetracionHechizo, nivelArma, intelecto;

            // ASIGANAR DATOS VARIABLES PERSONAJE

            nombreArma = Console.ReadLine();
            estiloArma = Console.ReadLine();
            aguante = int.Parse( Console.ReadLine());
            armadura = int.Parse(Console.ReadLine());
            golpeCritico = int.Parse(Console.ReadLine());
            daño = int.Parse(Console.ReadLine());
            penetracionArmadura = int.Parse(Console.ReadLine());
            penetracionHechizo = int.Parse(Console.ReadLine());
            nivelArma = int.Parse(Console.ReadLine());
            intelecto = int.Parse(Console.ReadLine());

            // DATOS DE ARMAS 

            var elegirArma = new Armas
            {
                NombreArma = nombreArma,
                EstiloArma = estiloArma,
                Aguante = aguante,
                Armadura = armadura,
                GolpeCritico = golpeCritico,
                Daño = daño,
                PenetracionArmadura = penetracionArmadura,
                PenetracionHechizo = penetracionHechizo,
                NivelArma = nivelArma,
                Intelecto = intelecto
            };

            //***************** DEFINIR VARIABLES DE ARMAS *********************

            string nombrePoder, estiloPoder;
            int dañoFisico, dañoMagico, dañoFuego, dañoHielo, dañoSombras, dañoBestia, dañoSagrado, dañoNatural;


            // ASIGANAR DATOS VARIABLES PERSONAJE

            nombrePoder = Console.ReadLine();
            estiloPoder = Console.ReadLine();
            dañoFisico = int.Parse(Console.ReadLine());
            dañoMagico = int.Parse(Console.ReadLine());
            dañoFuego = int.Parse(Console.ReadLine());
            dañoHielo = int.Parse(Console.ReadLine());
            dañoSombras = int.Parse(Console.ReadLine());
            dañoBestia = int.Parse(Console.ReadLine());
            dañoSagrado = int.Parse(Console.ReadLine());
            dañoNatural = int.Parse(Console.ReadLine());

            // DATOS DE PODERES 

            var elegirPoder = new Poderes
            {
                NombrePoder = nombrePoder,
                EstiloPoder = estiloPoder,
                DañoFisico = dañoFisico,
                DañoMagico = dañoMagico,
                DañoFuego = dañoFuego,
                DañoHielo = dañoHielo,
                DañoSombras = dañoSombras,
                DañoBestia = dañoBestia,
                DañoSagrado = dañoSagrado,
                DañoNatural = dañoNatural
            };

        }
    }
    
}
