using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Warlock : Hero
    {
        private const int HealthTakenChance = 20;
        private const int SpellChance = 10;
        private const int HealthTakenAmount = 50;
        private const int SpellDamage = 200;

        public Warlock(string name, Weapons weapons) : base(name, weapons)
        {

        }

        public override int Attack()
        {
            int attack = base.Attack();

            if (ThrowDice(SpellChance))
            {
                Console.WriteLine($"{Name} casts a spell!");
                return SpellDamage;
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(HealthTakenChance)) 
            {
                Console.WriteLine($"{Name} takes health points from the opponent!");
                Heal(HealthTakenAmount);
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
