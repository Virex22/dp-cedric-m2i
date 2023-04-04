using Patterns.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestMemento : AbstractTestHandler
    {
        public TestMemento()
        {
            this.patternName = "Memento";
        }

        protected override void testPattern()
        {
            Console.WriteLine("On crée un panier avec les option moteur classic, pneu classic, climatisation, bluetooth");
            CartOption cartOption = new CartOption();
            Memento memento = cartOption.AddOptions(EOptionsList.CLASSIC_MOTOR);
            cartOption.AddOptions(EOptionsList.CLASSIC_TIRE);
            cartOption.AddOptions(EOptionsList.AIR_CONDITIONNER);
            cartOption.AddOptions(EOptionsList.BLUETOOTH);
            Console.WriteLine("On ajout, moteur avancer en sauvegardant le memento");
            memento = cartOption.AddOptions(EOptionsList.ADVANCED_MOTOR);
            Console.WriteLine("On ajoute l'option nitro");
            cartOption.AddOptions(EOptionsList.NITRO);
            Console.WriteLine("On annule en remettant le memento");
            cartOption.Undo(memento);
            Console.WriteLine(cartOption.getOptionsString());
        }
    }
}
