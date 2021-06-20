using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************** | BIENVENIDO a World of Warcraft | ***************** ");
            Console.WriteLine("¿Deseas jugar?");
            Console.WriteLine("SI = 1\nNO = 0");
            int star = int.Parse(Console.ReadLine());
            if (star < 1)
            {
                Console.WriteLine("ADIOS!!");
                Console.WriteLine("Que te vaya bien colega!!");
            }
            else {

                Console.WriteLine("PARA JUGAR DEBES CREAR TU CUENTA:\n-------------------------------\n");
            }

            // DATOS DE LA CUENTA 
            Player newPerson = new Player();
            Console.WriteLine("INGRESA NOMBRE DE CUENTA:");
            newPerson.nameAccount = Console.ReadLine();
            Console.WriteLine("INGRESA CONTRASEÑA:");
            newPerson.passwordAccount = Console.ReadLine();
            newPerson.namePlayer = Console.ReadLine();
            newPerson.emailAccount = Console.ReadLine();
            newPerson.location = Console.ReadLine();

            Console.ReadKey();
        }
    }
}
