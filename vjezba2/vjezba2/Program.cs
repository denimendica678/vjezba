using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba2
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaB obj = new KlasaB();

            Console.WriteLine("Unesite niz znakova:"); 
            string znakovi = Console.ReadLine(); 
            
            if (znakovi.Length > 2) znakovi = obj.BezPrvogIZadnjeg(znakovi); 
            Console.WriteLine(znakovi);

            Console.ReadKey();
        }
    }
}
