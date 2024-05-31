using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class SlingShot : Weapons
    {
        private const int ArmourBreak = 20;

        public SlingShot() : base("Scythe", 25, ArmourBreak) { }

        public override int SpecialAbilityUse(int defaultDamage)
        {
            if (Random.Shared.Next(100) < SpecialAbility)
            {
                return defaultDamage + 50;
            }
            return defaultDamage;
        }
    }
}
