using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppz2_3
{
    internal class Program
    {/*Napišite program koji će zatražiti od korisnika da unese broj te će u ovisnosti o unešenom
broju ispisati jednu od sljedeće 4 poruke:
• Broj je djeljiv s 4
• Broj je djeljiv s 6
• Broj je djeljiv sa 4 i sa 6
• Broj nije djeljiv sa 4 ni sa 6
Ako je broj djeljiv i sa 4 i sa 6 mora se ispisati poruka “Broj je djeljiv sa 4 i sa 6”*/
        static void Main(string[] args)
        {
            Console.WriteLine("Upsi bilo koji cijeli broj: ");
            int broj = Convert.ToInt32(Console.ReadLine());
            if (broj % 4 == 0)
            {
                Console.WriteLine("Broj je djeljiv s 4. ");
            }
            if (broj % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv s 6. ");
            }
            if (broj % 4 == 0 && broj % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv s 4 i sa 6. ");
            }
            if(broj % 4 != 0 && (broj % 6 !=0))
            {
                Console.WriteLine("Broj nije djeljiv sa 4 ni sa 6. ");
            }
            Console.ReadKey();
        }
    }
}
