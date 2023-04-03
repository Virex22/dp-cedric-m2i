using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public class RegistrationFormFrance : AbstractRegistrationForm
    {
        public RegistrationFormFrance(IFormImplementation form) : base(form)
        {
        }

        public override bool CheckSubmition()
        {
            return this.state.ToLower() == "france";
        }
    }
}
