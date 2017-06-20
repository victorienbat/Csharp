using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyennePonderee
{
    class Program
    {
        static void Main(string[] args)
        {
            //            CALCUL DE LA MOYENNE PONDEREE DES NOTES D’UN ETUDIANT DANS  UNE MATIERE
            //  Il s’agit de calculer une moyenne sur la base de trois notes sachant que:
            // une note de devoir surveillé a un coefficient de 3
            // une note d’interrogation écrite a un coefficient de 2
            // une note de travaux pratique a un coefficient de 1

            double NDS, NIE, NTP;   // Note devoir Surveillé, Note Interrogation Ecrite, Note Travaux Pratique
            double moyenne;

            Console.WriteLine(" Saisie la note du devoir surveillé");
            NDS = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Saisie la note de l'interrogation ecrite");
            NIE = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Saisie la note du travaux pratique");
            NTP = Convert.ToDouble(Console.ReadLine());

            moyenne = ((NDS * 3) + (NIE * 2) + NTP) / (3 + 2 + 1);
            Console.WriteLine(" La moyenne est de " + moyenne);
            Console.ReadLine();


        }
    }
}
