using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class MasterSword : Weapons 
    {
        private const int CritChance = 10;

        public MasterSword():base("Master Sword", 20, CritChance) { }

        public override int SpecialAbilityUse(int defaultDamage)
        {
            if(Random.Shared.Next(100) < SpecialAbility)
            {
                return defaultDamage * 2;
            }
            return defaultDamage;
        }
    }
}
