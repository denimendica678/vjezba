using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba1
{
    class KlasaC
    {
        public int Zbroj(int[] br)
        {
            int zbroj = 0; for (int i = 0; i < br.Length; i++)
            {
                zbroj += br[i];
            }

            return zbroj;
        }

        public double Prosjek(int[] br)
        {
            int sum = 0;
            for (int i = 0; i < br.Length; i++)
            {
                sum += br[i];
            }

            return (double)sum / br.Length;

        }
    }
}
