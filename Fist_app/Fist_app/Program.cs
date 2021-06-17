using System;

namespace Fist_app
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                Console.WriteLine($"Hay {args.Length}  argumentos");
                Console.WriteLine($"Tu nombre es: { args[0]}");
                if (args.Length > 1)
                    Console.WriteLine($"Tu apellido es: { args[1]}");
            }else
                Console.WriteLine("Hola desconocido");
                Console.Read();
        }
    }
}
