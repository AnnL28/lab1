using System;

namespace labs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(HW1.QueueTime(new int[] { 5, 3, 4 }, 1));
            Console.WriteLine(HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2));
            Console.WriteLine(HW1.QueueTime(new int[] { 2, 3, 10 }, 2));          
        }
    }
}


