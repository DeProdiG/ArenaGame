using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class FireScythe : Weapons
    {
        private const int HealthLimit = 20;
        private const int InstantDeath = 10;

        public FireScythe(): base("Scythe", 25, InstantDeath) { }

        public override int SpecialAbilityUse(int defaultDamage)
        {
            if (Random.Shared.Next(100) < SpecialAbility)
            {
                if (defaultDamage < HealthLimit)
                {
                    return int.MaxValue;
                }
            }
            return defaultDamage;
        }
    }
}
