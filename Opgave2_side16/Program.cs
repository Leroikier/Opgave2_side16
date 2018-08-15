using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2_side16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input "decimaltal"
            Console.WriteLine("Indtast decimaltal");
            decimal decimaltal = decimal.Parse(Console.ReadLine());

            //Input bliver rundet op til et hel tal med 2 decimaler
            decimaltal = Math.Round(decimaltal,2);
           
            //Udskrivning af "resultat" + tekst
            Console.WriteLine(decimaltal + " Tallet bliver rundet op til og med 2 decimaler");

            //Slut
            Console.ReadKey();
        }
    }
}
