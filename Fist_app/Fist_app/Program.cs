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
    class Persona
    {
       
        public string imprimeNombres(string name1,string name2, string name3, string name4) {
            return "Nombres: "+ name1 +" " + name2 + " " + name3 + " " + name4+".";
        }
        public string imprimeDatos(int edad, int peso, double altura) {
            return  "Tienes: " + edad +" años\n Tu peso es:" + peso +" Kg.\n Tu estatura es: " + altura + "cm." ;
        }
        public string imprimeEstado(string estadoCivil, string provincia, string ciudad) {
            return "Estado civil: "+estadoCivil +"\n Provincia: "+provincia +"\n Ciudad: " + ciudad+".";
        }

    }
}
