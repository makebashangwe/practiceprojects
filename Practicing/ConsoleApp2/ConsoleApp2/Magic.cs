using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Magic
    {
        public string SpellName { get; private set; }
        public int PowerLevel { get; private set; }
        public List<String> AvailableSpells { get; private set; }

        public Magic(string spellName, int powerLevel, List<string> availableSpells)
        {
            spellName = SpellName;
            powerLevel = PowerLevel;
            availableSpells = AvailableSpells;
        }

        public void CastSpell(string spell)
        {
            if (AvailableSpells.Contains(spell))
            {
                Console.WriteLine($"Casting {SpellName} (power level: {PowerLevel}!");

            }
            else
            {
                Console.WriteLine($"You don't know the spell {spell}.");
            }
        }

        public  class FireEarth
        {

        }
        public void GetDescription()
        {
        }
    }
}
