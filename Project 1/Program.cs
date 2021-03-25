using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            int[] Array1 = new int[100000];
            int x = 6;
            Filling(Array1);
            watch.Start();
            Search(Array1, x);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds + " spent");
            
        }


        static void Filling (int[] Array)
        {
            Random rd = new Random();
             for (int i = 0; i<Array.Length; i++)
            {
                Array[i] = rd.Next(7, 101);
            }
                Array[99999] = 6;
        }


        
        static void Search(int[] Array, int x)
        {
            for (int i=0; i < Array.Length; i++)
            {
                if (Array[i] == x)
                {
                Console.WriteLine($"The number {x} is found in the cell {i}");
                break;
                }
            } 
        }
    }
}
