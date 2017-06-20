using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionDeTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONVERSION DE TEMPERATURES
            //En utilisant la formule C = (5 / 9)(F - 32) écrire un programme qui lit une température
            //exprimée en degrés Fahrenheit et affiche sa valeur en degrés Celsius.

            decimal C, F;
            string saisie;

            Console.WriteLine(" Entrer une temperature en degrés Fahrenheit");
            saisie = Console.ReadLine();
            F = Convert.ToDecimal(saisie);
            C = (5 * (F - 32)) / 9;
            Console.Write(" La temperature est de " + C + " degrés Celsius");
            Console.ReadLine();
        }
    }
}
