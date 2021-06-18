namespace Fist_app
{
    class Persona
    {
       
        public string imprimeNombres(string name1,string name2, string name3, string name4) {
            return "Nombres: "+ name1 +" " + name2 + " " + name3 + " " + name4+".";
        }
        public string imprimeDatos(int edad, int peso, double altura) {
            return  "Tienes: " + edad +" años.\nTu peso es:" + peso +" Kg.\nTu estatura es: " + altura + " cm." ;
        }
        public string imprimeEstado(string estadoCivil, string provincia, string ciudad) {
            return "Estado civil: "+estadoCivil+".\n" +"Provincia: "+provincia+".\n" + "Ciudad: " + ciudad+".";
        }

    }
}
