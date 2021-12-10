using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba2
{
    class KlasaB
    {
        public string BezPrvogIZadnjeg(string znakovi) 
        {
            return znakovi.Substring(1, znakovi.Length-2);
        }
    }
}
