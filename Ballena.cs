using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Ballena : Mamifero
    {
        //Constructor
        public Ballena(string n, double p): base(n, p)
        {
        }

        //Metodos 

        public void mostrarballena()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es: "+ nom);
            Console.WriteLine("El peso de la ballena es: " + peso + "Kg");
        }
    }
}
