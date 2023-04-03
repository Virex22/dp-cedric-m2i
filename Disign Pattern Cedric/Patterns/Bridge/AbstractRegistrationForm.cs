using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    abstract public class AbstractRegistrationForm
    {
        protected string firstname;
        protected string lastname;
        protected int age;
        protected string state;
        protected IFormImplementation form;

        protected AbstractRegistrationForm(IFormImplementation form)
        {
           this.form = form;
        }

        public void Show()
        {
            form.DrawText();
            form.HandleInputZone();
        }

        public string GenerateFile()
        {
            if (this.CheckSubmition())
                return "<FILE>\r\nYour immatriculation is : " + this.GenerateRandomImmatriculation() + "\r\n</FILE>";
            return "Invalid form data";
        }

        public void SetInput(string firstname, string lastname, int age, string state)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.state = state;
        }

        abstract public bool CheckSubmition();

        // Exemple : AA 123 AA
        private string GenerateRandomImmatriculation()
        {
            string plate = "";
            Random rand = new Random();

            for (int i = 0; i < 2; i++)
                plate += (char)rand.Next(65, 90);

            plate += " ";

            for (int i = 0; i < 3; i++)
                plate += rand.Next(0, 9);

            plate += " ";

            for (int i = 0; i < 2; i++)
                plate += (char)rand.Next(65, 90);

            return plate;
        }
    }
}
  