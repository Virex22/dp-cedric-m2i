using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public class RegistrationFormLuxembourg : AbstractRegistrationForm
    {
        public RegistrationFormLuxembourg(IFormImplementation form) : base(form)
        {
        }

        public override bool CheckSubmition()
        {
            return this.state.ToLower() == "luxembourg";
        }
    }
}
