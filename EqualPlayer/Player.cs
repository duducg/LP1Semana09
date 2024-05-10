using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqualPlayer
{
    public class Player
    {
        public PlayerClass PClass { get; }
        public string Name { get; }
        
        public Player (PlayerClass pClass, string name)
        {
            PClass = pClass;
            Name = name;

        }
        
        public override int GetHashCode()
        {
	        return PClass.GetHashCode() ^ Name.GetHashCode(); 
        }

        public override bool Equals(object obj)
        {
            Player other = obj as Player;
        	if (other == null) return false;
        	return PClass == other.PClass && Name == other.Name;
        }
        


    }
}