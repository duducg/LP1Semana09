using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ls_a = new List<int>() { 1, 10, -30, 10, -5 };
            //Stacks and Queues can take an ICollection as param
            Stack<int> stack_a = new Stack<int>(ls_a); 
            Queue<int> queue_a = new Queue<int>(ls_a);
            HashSet<int> hashSet_a = new HashSet<int> { 1, 10, -30, 10, -5 };

            //Print List values
            int count = 0;
            Console.Write("List:");            
            foreach (int i in ls_a)
            {
                if (count > 0)Console.Write($", {i}");
                else Console.Write($" {i}");
                count++;
            }
            Console.Write("\n");
            count = 0;
            
           
        }
    }
}
