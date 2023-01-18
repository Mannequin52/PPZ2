using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppz2_1
{
    internal class Program
    {
        /*Napišite program koji će od korisnika uzeti string, te definirajte i ispišite novi string 
         * koji će sadržavati sve znakove unešenog stringa osim prva dva i zadnja dva znaka. Ako je niz dužine 
         * manje od 5 znakova treba ispisati cijeli niz.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite neku recenicu: ");
            string a = Console.ReadLine();
            int stringLength = a.Length;

            if(a.Length < 5){
                Console.WriteLine(a);
            }

            Console.WriteLine(a.Substring(2, a.Length -2));
            
            Console.ReadKey();
        }
    }
}
