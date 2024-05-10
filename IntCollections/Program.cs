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

            
            //All of these can use foreach since they all implement IEnumerable
            //Printing using IEnumerable<T>
            
            List<IEnumerable<int>> collects = new List<IEnumerable<int>>() 
            {
                ls_a,
                stack_a,
                queue_a,
                hashSet_a
            };
            
            foreach(IEnumerable<int> cols in collects )
            {
                int count = 0;
                string typeName = cols.GetType().Name;
                typeName = typeName.Remove(typeName.Length-2);
                Console.Write($"{typeName}:");
                foreach(int i in cols)
                {
                    if (count > 0)Console.Write($", {i}");
                    else Console.Write($" {i}");
                    count++;

                }
                Console.Write("\n");
                count = 0;
            }

    


            #region Less efficient printing
            /* //Print List values
            int count = 0;
            Console.Write("List:");            
            foreach (int i in ls_a)
            {
                if (count > 0)Console.Write($", {i}");
                else Console.Write($" {i}");
                count++;
            }
            Console.Write("\n");
            

            //Print Stack Values
            count = 0;
            Console.Write("Stack:");  
            foreach (int i in stack_a )
            {
                if (count > 0)Console.Write($", {i}");
                else Console.Write($" {i}");
                count++;                
            }
            Console.Write("\n");
            
            //Print Queue Values
            count = 0;
            Console.Write("Queue:");  
            foreach (int i in queue_a )
            {
                if (count > 0)Console.Write($", {i}");
                else Console.Write($" {i}");
                count++;                
            }
            Console.Write("\n");

            //Print HashSet Values
            count = 0;
            Console.Write("HashSet:");  
            foreach (int i in hashSet_a )
            {
                if (count > 0)Console.Write($", {i}");
                else Console.Write($" {i}");
                count++;                
            } */
            #endregion
            
            
           
        }
    }
}
