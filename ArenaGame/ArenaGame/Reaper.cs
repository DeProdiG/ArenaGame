using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Reaper : Hero
    {
        private const int HealthLimit = 50;
        private const int InstantDeath = 10;
        private const int CritChance = 25;

        public Reaper(string name, Weapons weapons) : base(name, weapons)
        {

        }

        public override int Attack()
        {
            int attack = base.Attack();
            
            if(ThrowDice(CritChance))
            {
                Console.WriteLine($"{Name} lands a crit hit!");
                attack *= 2;
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(InstantDeath) && Health < HealthLimit) 
            {
                Console.WriteLine($"{Name} instant kills the opponent!");
                incomingDamage = Health;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
