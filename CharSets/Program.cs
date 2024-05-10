using System;
using System.Collections.Generic;
using System.IO;

namespace CharSets
{
    class Program
    {
        static void Main(string[] args)
        {   
            //using an empty hashset and intersecting will add the other set in
            HashSet<char> intersect_char = new HashSet<char>();
            //can take in 0 + files in command line
            if (args == null || args.Length == 0)
            {
                //do nothing

            }
            else
            {
                int count = 0;
                foreach (string file in args)
                {
                    //returns a string array of all lines 
                    string[] strings = File.ReadAllLines(file);
                    HashSet<char> chars_ = new HashSet<char>();
                    //check if any member has 2 chars
                    foreach (string c in strings)
                    {
                        if (c.Length > 1)
                        {
                            Console.WriteLine("ERROR!!");
                            return;
                        }
                        else chars_.Add(char.Parse(c));

                    }

                    if (count == 0)
                    {
                        intersect_char = chars_;
                    }
                    else intersect_char.IntersectWith(chars_);            
                    count++;

                }
                
            }
            //print chars
            List<char> outList = new List<char>(intersect_char);
            outList.Sort();
            foreach (char c in outList)
            {
                Console.WriteLine(c);
            } 
            

        }
    }
}
