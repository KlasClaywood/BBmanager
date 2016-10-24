using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_BloodBowlManager.Objects;

namespace Console_BloodBowlManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Positional HumanLineman = new Positional("Lineman", "Human", null, 50, 6, 3, 3, 8, new string[] { "General" }, new string[] { "Strength", "Agility", "Passing" });
            Player playerone = new Player("Karl Huntsmann", HumanLineman, 8);
            Player playertwo = new Player("Henri Bowler", HumanLineman, 7);
            List<Player> team1 = new List<Player>();
            team1.Add(playerone);
            team1.Add(playertwo);
            foreach (var player in team1)
            {
                Console.WriteLine(player.ToString());
            }
            Console.ReadKey();
        }
    }
}
