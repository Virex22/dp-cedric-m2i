using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Memento
{
    public class Memento
    {
        protected List<EOptionsList> state = new List<EOptionsList>();

        public void SetState(List<EOptionsList> state)
        {
            foreach (var item in state)
            {
                this.state.Add(item);
            }
        }

        public List<EOptionsList> GetState()
        {
            return this.state;
        }
    }
}
