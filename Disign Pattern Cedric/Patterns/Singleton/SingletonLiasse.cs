using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    class SingletonLiasse
    {
        private SingletonLiasse() { }

        private static SingletonLiasse instance = null;
        private List<string> liasse = new List<string>();

        public static SingletonLiasse getInstance()
        {
            if (instance == null)
            {
                instance = new SingletonLiasse();
            }
            return instance;
        }

        public void Add(string doc)
        {
            liasse.Add(doc);
        }

        public void Remove(string doc)
        {
            liasse.Remove(doc);
        }

        public List<string> GetLiasse()
        {
            return liasse;
        }
    }
}
