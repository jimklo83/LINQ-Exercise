namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var paradoxGames = new List<string>() 
            { 
                "Crusader Kings", 
                "Crusader Kings 2", 
                "Crusader Kings 3", 
                "Stellaris", 
                "Europa Universalis", 
                "Europa Universalis II", 
                "Europa Universalis III", 
                "Europa Universalis IV" 
            };

            Console.WriteLine("Paradox games by length of name:\n");
            
            var orderedGames = paradoxGames.OrderBy(x => x.Length).ToList();

            orderedGames.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nPARADOX GAMES ALL IN UPPER CASE AND DESCENDING LENGTH:\n");

            var toUpper = paradoxGames.OrderByDescending(x => x.Length).Select(x => x.ToUpper()).ToList();

            toUpper.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nStart: Paradox games as classes...\n");

            var game01 = new ParadoxGame("Crusader Kings", false);
            var game02 = new ParadoxGame("Crusader Kings 2", true);
            var game03 = new ParadoxGame("Crusader Kings 3", true);
            var game04 = new ParadoxGame("Stellaris", false);
            var game05 = new ParadoxGame("Europa Universalis", false);
            var game06 = new ParadoxGame("Europa Universalis II", true);
            var game07 = new ParadoxGame("Europa Universalis III", true);
            var game08 = new ParadoxGame("Europa Universalis IV", true);

            var paradoxGamesClass = new List<ParadoxGame>() 
            {
                game01,
                game02,
                game03,
                game04,
                game05,
                game06,
                game07,
                game08,
            };

            Console.WriteLine("Original Paradox titles:\n");

            var originals = paradoxGamesClass.Where(x => x.IsSequel == false).ToList();
            
            originals.ForEach(x => Console.WriteLine(x.Name));

            Console.WriteLine("\nParadox titles that are sequels:\n");

            var sequels = paradoxGamesClass.Where(x => x.IsSequel == true).ToList();

            sequels.ForEach(x => Console.WriteLine(x.Name));
        }
    }
}
