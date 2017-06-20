 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionHeures
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONVERSION D’UNE DUREE EXPRIMEE EN SECONDES EN HEURES,
            //MINUTES ET SECONDES
            //II s'agit pour un nombre de secondes entré au clavier d'en déduire, son expression
            //en nombre d'heures de minutes et de secondes.

            int h, m, s;

            Console.WriteLine(" Entrer le nombre de secondes a convertir");
            s = Convert.ToInt32(Console.ReadLine());
            h = s / 3600;
            s = s % 3600;
            m = s / 60;
            s = s % 60;
            Console.WriteLine(" ce nombre de secondes equivaut a : " + h + "h " + m + "M " + s + "S ");
            Console.ReadLine();


        }
    }
}
