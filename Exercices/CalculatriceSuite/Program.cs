using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatriceSuite
{
    class Program
    {
        static void Main(string[] args)
        {
            //CALCULATRICE SUITE
            //Modifier le programme précédent pour effectuer une Division.

            //double nbre1, nbre2;
            //double division;

            //Console.WriteLine("Indique le nbre1");
            //nbre1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Indique le nbre2");
            //nbre2 = Convert.ToDouble(Console.ReadLine());
            //division = nbre1 / nbre2;
            //Console.Write(" La division de " + nbre1);
            //Console.Write(" par " + nbre2);
            //Console.WriteLine(" donne :" + division);
            //Console.ReadLine();

            // Ou bien 

            double nbre1, nbre2;
            double division;
            string saisie;


            Console.WriteLine(" Entrer le premier nombre");
            saisie = Console.ReadLine();
            nbre1 = Convert.ToDouble(saisie);
            Console.WriteLine(" Entrer le deuxième nombre");
            saisie = Console.ReadLine();
            nbre2 = Convert.ToDouble(saisie);
            division = nbre1 / nbre2;
            Console.Write(" la division de " + nbre1);
            Console.Write(" par " + nbre2);
            Console.WriteLine(" donne : " + division);
            Console.ReadLine();
        }
    }
}
