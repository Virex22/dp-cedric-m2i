using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Proxy
{
    public class Film : IAnimation
    {
        public void Click()
        {
            Console.WriteLine("Click du film");
        }

        public void Draw()
        {
            Console.WriteLine("Dessin du film");
        }

        public void Load()
        {
            Console.WriteLine("Chargement du film");
        }

        public void Play()
        {
            Console.WriteLine("Film en train de se jouer");
        }
    }
}
