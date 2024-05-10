using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower2
{
    class Program
    {
        static void Main(string[] args)
        { 
            //filename
            string filename = args[0];
            //bool flag
            bool exit = false;
            //Using StreamWriter
            using StreamWriter sw = new StreamWriter(filename);
                       
            while (!exit)
            {
                
                string userInput = Console.ReadLine();
                if (userInput == "")
                {
                    exit = true;                    
                    break;
                }
                else
                {
                    sw.WriteLine(userInput);
                }
                
            }
            

            
            

            
            
        }
    }
}
