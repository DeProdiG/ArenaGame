using ArenaGame;

namespace ConsoleGame
{
    internal class Program
    {
        private static List<Hero> heroes;
        private static List<Weapons> weapons;
        static void Main(string[] args)
        {
            HeroesAndWeapons();

            Console.Write("Enter number of battles:");
            int rounds = Int32.Parse(Console.ReadLine());
            int oneWins = 0, twoWins = 0;

            Weapons fireScythe = new FireScythe();
            Weapons masterSword = new MasterSword();
            Weapons slingShot = new SlingShot();

            for (int i = 0; i < rounds; i++)
            {
                Hero one = ChooseHero(1);
                Hero two = ChooseHero(2);

                Console.WriteLine($"Arena fight between: {one.Name} and {two.Name}");
                Arena arena = new Arena(one, two);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}");
                if (winner == one) oneWins++; else twoWins++;
            }
            Console.WriteLine();
            Console.WriteLine($"One has {oneWins} wins.");
            Console.WriteLine($"Two has {twoWins} wins.");

            Console.ReadLine();
        }

        private static void HeroesAndWeapons()
        {
            weapons = new List<Weapons>
            {
                new FireScythe(),
                new MasterSword(),
                new SlingShot()
            };

            heroes = new List<Hero>
            {
                new Knight("Sir Lancelot", null),
                new Rogue("Robin Hood", null),
                new Reaper("Azrael", null),
                new Warlock("Eliphas", null)
            };
        }

        private static Hero ChooseHero(int heroNumber)
        {
            Console.WriteLine($"Choose hero {heroNumber}:");

            for(int i = 0; i < heroes.Count; i++)
            {
                Console.WriteLine($"{i+1}. {heroes[i].GetType().Name} - {heroes[i].Name}");
            }
            int heroChoice = Int32.Parse(Console.ReadLine()) - 1;

            Hero selectedHero = heroes[heroChoice];
            Weapons selectedWeapon = ChooseWeapon();

            selectedHero.SetWeapon(selectedWeapon);

            return selectedHero;
        }

        private static Weapons ChooseWeapon()
        {
            Console.WriteLine("Choose a weapon:");

            for(int i = 0; i < weapons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{weapons[i].Name}");
            }
            int weaponChoice = Int32.Parse(Console.ReadLine()) - 1;

            return weapons[weaponChoice];
        }
    }
}
