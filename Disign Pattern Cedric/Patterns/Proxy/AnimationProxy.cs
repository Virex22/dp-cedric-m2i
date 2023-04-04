using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Proxy
{
    public class AnimationProxy : IAnimation
    {
        protected Film? film;
        protected string photo = "Photo";

        public AnimationProxy()
        {

        }

        public void Click()
        {
            if (film == null)
            {
                film = new Film();
                film.Load();
            }
            film.Play();
        }

        public void Draw()
        {
            if (film != null)
                film.Draw();
            else
                this.Draw(this.photo);
        }
        public void Draw(string photo)
        {
            Console.WriteLine("Affichage de la Photo : " + this.photo);
        }
    }
}
