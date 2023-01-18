using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppz2_4
{
    internal class Program
    {
        /*Napišite program koji će izračunati vrijednost PDV-a na osnovu od korisnika unešenih cijena bez PDV-a i s PDV-om.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši cijenu bez PDV-a: ");
            int bez = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Upiši cijenu sa PDV-om: ");
            int sa = Convert.ToInt32(Console.ReadLine());

            int a = sa - bez;
            double b = sa / a;
            Console.WriteLine("Vrijednost PDV-a je " + b);
            Console.ReadKey();
        }
    }
}
