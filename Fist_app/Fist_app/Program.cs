using System;

namespace Fist_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu primer nombre:");
            var name1 = Console.ReadLine();
            Console.WriteLine("Ingresa tu segundo nombre:");
            var name2 = Console.ReadLine();
            Console.WriteLine("Ingresa tu primer apellido:");
            var name3 = Console.ReadLine();
            Console.WriteLine("Ingresa tu segundo apellido:");
            var name4 = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu peso:");
            int peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu altura:");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu estado civil:");
            var estadoCivil = Console.ReadLine();
            Console.WriteLine("Ingresa tu provincia:");
            var provincia = Console.ReadLine();
            Console.WriteLine("Ingresa tu ciudad:");
            var ciudad = Console.ReadLine();
            DateTime fechaIngreso = DateTime.Now;

            Persona namePerson;
            namePerson = new Persona(); 
               
            Console.WriteLine("******************| PROGRAMA | ******************** ");
            Console.WriteLine(namePerson.imprimeNombres(name1,name2,name3,name4));
            Console.WriteLine(namePerson.imprimeDatos(edad, peso,altura));
            Console.WriteLine(namePerson.imprimeEstado(estadoCivil, provincia, ciudad));
            Console.WriteLine("Fecha Actual: " + fechaIngreso);
            Console.ReadKey();
        }    
    }
}
