using System;
using System.Collections.Generic;

namespace ConsolePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variables
            string mot;
            int longeurMot;
            bool test = false;
            int iteration;
            #endregion

            Console.WriteLine("Veuillez entrer le mot a tester.");
            mot = Console.ReadLine();

            longeurMot = mot.Length;
            iteration = longeurMot-1;
            //Teste la première moitié du mot avec la dernière moitié.
            for (int i = 0; i <= (longeurMot/2)-1; i++)
            {
                test = (mot[i] == mot[iteration] ? true : false);             
                --iteration;
            }
            #region affichage
            if(test)
            {
                Console.WriteLine("Ce mot est un palindrome !");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ce mot n'est pas un palindrome.");
                Console.ReadLine();
            }
            #endregion
        }
    }
}
