using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImposto.Aula09
{
    public class Piano
    {
        public void Play(IList<INota> song)
        {
            foreach (var nota in song)
            {
                Console.Beep(nota.Frequency, 300);
            }
        }
    }
}