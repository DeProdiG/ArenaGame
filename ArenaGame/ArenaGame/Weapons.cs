using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Weapons
    {
        public string Name { get; set; }
        public int MoreDamage { get; set; }

        public int SpecialAbility {  get; set; }

        public Weapons(string name, int moreDamage, int specialAbility) 
        {
            Name = name;
            MoreDamage = moreDamage;
            SpecialAbility = specialAbility;
        }

        public virtual int SpecialAbilityUse (int defaultDamage)
        {
            return defaultDamage;
        }
    }
}
