using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Memento
{
    public class VehicleOptions
    {
        public List<KeyValuePair<EOptionsList, EOptionsList>> GetOptionsIncompatible()
        {
            return new List<KeyValuePair<EOptionsList, EOptionsList>> {

                new KeyValuePair<EOptionsList, EOptionsList>
                (EOptionsList.CLASSIC_MOTOR, EOptionsList.ADVANCED_MOTOR),

                new KeyValuePair<EOptionsList, EOptionsList>
                (EOptionsList.CLASSIC_TIRE,EOptionsList.ADVANCED_TIRE),

            };
        }
    }
}
