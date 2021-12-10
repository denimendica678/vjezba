using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[5];
            KlasaC obj = new KlasaC();

            Console.WriteLine("Upišite 5 cijelih brojeva:");
            for (int i = 0; i < 5; i++)
            {
                string broj = Console.ReadLine();
                lista[i] = Convert.ToInt32(broj); 
            }
            
            int zbroj = obj.Zbroj(lista); 
            Console.WriteLine(zbroj);
            double prosjek = obj.Prosjek(lista);
            Console.WriteLine(prosjek);

        }
    }
}
