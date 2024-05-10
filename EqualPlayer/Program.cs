using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqualPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing HashSet<Player>

            //Create a HashSet
            HashSet<Player> setOfPlayers = new HashSet<Player>()
            {
                new Player(PlayerClass.Tank, "Ana"),
                new Player(PlayerClass.Slayer, "Paulo"),
                new Player(PlayerClass.Tank, "Ana"),
            };
            
            //testing a foreach:
            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.PClass}");
            }


        }

       
    }
}
