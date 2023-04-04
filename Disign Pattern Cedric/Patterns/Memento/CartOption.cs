using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Memento
{
    public class CartOption
    {
        protected List<EOptionsList> options = new List<EOptionsList>();

        public Memento AddOptions(EOptionsList option)
        {
            Memento memento = new Memento();
            memento.SetState(options);
            this.SafeAddOptions(option);
            return memento;
        }

        public void Undo(Memento memento)
        {
            options = memento.GetState();
        }

        public string getOptionsString()
        {
            string stringOptions = "";
            foreach (EOptionsList option in options)
            {
                stringOptions += "   " + option.ToString() + "\r\n";
            }
            return stringOptions;
        }

        private void SafeAddOptions(EOptionsList option)
        {
            VehicleOptions vehicleOptions = new VehicleOptions();
            foreach (var incompatible in vehicleOptions.GetOptionsIncompatible())
            {
                if (incompatible.Key == option)
                {
                    if (options.Contains(incompatible.Value))
                    {
                        options.Remove(incompatible.Value);
                        break;
                    }
                }
                if (incompatible.Value == option)
                {
                    if (options.Contains(incompatible.Key))
                    {
                        options.Remove(incompatible.Key);
                        break;
                    }
                }
            }
            options.Add(option);
        }
    }
}
