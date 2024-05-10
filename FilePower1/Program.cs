using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
            //First input is filename.txt 
            //  From command line
            //After first input:
            //Capture input and save into a queue instance
            //When userinput == null or empty >>> write all queued strings into file and end sequence

            //filename
            string filename = args[0];
            //bool flag
            bool exit = false;
            //Queue
            Queue<string> user_queue = new Queue<string>();
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
                    user_queue.Enqueue(userInput);
                }
                
            }
            //Write queue to file
            File.WriteAllLines(filename, user_queue);

            
            
        }
    }
}
