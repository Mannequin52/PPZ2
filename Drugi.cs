using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ppz2_2
{
    internal class Program
    {
        /*Napišite program koji će provjeriti jesu li vrijednosti sadržane u int varijablama x, y i z 
         * stranice pravokutnog trokuta. U program uključite i provjeru da vrijednosti varijabli 
         * za ovakav primjer imaju smislene vrijednosti (iznosi moraju biti veći od 0).*/
        static void Main(string[] args)
        {
            int x = 3;
            int y = 5;
            int z = 8;

            if (x == 0 || y==0 || z == 0)
            {
                Console.WriteLine("Vrijednost stranice ne može biti 0. Pokušaj ponovno.");
                
            }
            double z2 = Math.Pow(z, 2);
            double x2 = Math.Pow(x, 2);
            double y2 = Math.Pow(y, 2);
            if(x2 + y2 == z2)
            {
                Console.WriteLine("Stranice su pravokutni trokut.");
            }
            else
            {
                Console.WriteLine("Stranice nisu pravokutni trokut.");
            }
            Console.ReadKey();  
        }
    }
}
