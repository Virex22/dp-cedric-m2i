using Patterns.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestBridge : AbstractTestHandler
    {
        public TestBridge()
        {
            this.patternName = "Bridge";
        }

        protected override void testPattern()
        {
            Console.WriteLine("Creation d'un Formulaire d'immatriculation francais en HTML");
            AbstractRegistrationForm form = new RegistrationFormFrance(new FormImplementationHTML());
            Console.WriteLine("remplissage avec les valeurs : vincent remy 21 france");
            form.SetInput("vincent", "remy", 21, "france");
            form.Show();
            Console.WriteLine("fichier générer : " + form.GenerateFile());

            Console.WriteLine("Creation d'un Formulaire d'immatriculation luxembourgois avec Apple");
            form = new RegistrationFormLuxembourg(new FormImplementationApple());
            Console.WriteLine("remplissage avec les valeurs : vincent remy 21 luxembourg");
            form.SetInput("vincent", "remy", 21, "luxembourg");
            form.Show();
            Console.WriteLine("fichier générer : " + form.GenerateFile());

            Console.WriteLine("Creation d'un Formulaire d'immatriculation francais en Apple");
            form = new RegistrationFormFrance(new FormImplementationApple());
            Console.WriteLine("remplissage avec les valeurs : vincent remy 21 france");
            form.SetInput("vincent", "remy", 21, "france");
            form.Show();
            Console.WriteLine("fichier générer : " + form.GenerateFile());

            Console.WriteLine("Creation d'un Formulaire d'immatriculation luxembourgois avec HTML");
            form = new RegistrationFormLuxembourg(new FormImplementationHTML());
            Console.WriteLine("remplissage avec les valeurs : vincent remy 21 luxembourg");
            form.SetInput("vincent", "remy", 21, "luxembourg");
            form.Show();
            Console.WriteLine("fichier générer : " + form.GenerateFile());

            Console.WriteLine("Creation d'un Formulaire d'immatriculation francais en HTML");
            form = new RegistrationFormFrance(new FormImplementationHTML());
            Console.WriteLine("remplissage avec les valeurs : vincent remy 21 luxembourg");
            form.SetInput("vincent", "remy", 21, "luxembourg");
            form.Show();
            Console.WriteLine("fichier générer : " + form.GenerateFile());
        }
    }
}
