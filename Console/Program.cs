using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONSOLE:
            //Ecrire un programme qui saisit un code Unicode en décimal et affiche le caractère
            //correspondant.
            //Exemple la saisie de l’entier 65 donne le caractère « A ».
            //Que se passe t-il lorsque vous tapez 7 ?

            int code;
            char caractere , reponse ;

            Console.WriteLine(" Saisie un Code : ");
            code = Convert.ToInt32(Console.ReadLine());
            caractere = Convert.ToChar(code);
            Console.WriteLine(" Ce code affiche le caractere : " + caractere);
            Console.ReadLine();

            //caractere = (char)code;

            // Partant de la lettre vers de code ? ? ?

            //Console.WriteLine(" Saisie un Code : ");
            //reponse = Console.ReadLine();
            //caractere = reponse[0];
            //Console.WriteLine( caractere);






        }
    }
}
