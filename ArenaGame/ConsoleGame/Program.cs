using ArenaGame;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of battles:");
            int rounds = Int32.Parse(Console.ReadLine());
            int oneWins = 0, twoWins = 0;

            Weapons fireScythe = new FireScythe();
            Weapons masterSword = new MasterSword();
            Weapons slingShot = new SlingShot();

            for (int i = 0; i < rounds; i++)
            {
                /*Hero one = new Knight("Sir Lancelot", masterSword);
                 Hero two = new Rogue("Robih Hood", slingShot);   OLD HEROES*/
                Hero one = new Reaper("Azrael", fireScythe);// NEW
                Hero two = new Warlock("Eliphas", slingShot);// ONES

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
    }
}
