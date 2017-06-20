using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            //CALCULATRICE
            //Ecrivez un programme qui demande deux nombres à l’utilisateur et qui affiche la
            //somme de ces deux nombres.

            double nbre1, nbre2;
            double somme;

            Console.WriteLine("Indique le nbre1");
            nbre1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indique le nbre2");
            nbre2 = Convert.ToDouble(Console.ReadLine());
            somme = nbre1 + nbre2;
            Console.Write(" La somme de " + nbre1);
            Console.Write(" Et de " + nbre2);
            Console.WriteLine(" est :" + somme);
            Console.ReadLine();


        }
    }
}
