using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[] { 1, 3, 2, 5, 4, 6, 7 };  
            Sort x = new Sort();

            x.QuickSort(lista, 1, lista.Length - 2); 

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.ReadKey();
  
        }   
    }
}
