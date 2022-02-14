using System;

namespace labs
{
    class Program
    {
        static void Main()
        {
            HW1.QueueTime(new int[] { 5, 3, 4 }, 1);
            HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2);
            HW1.QueueTime(new int[] { 2, 3, 10 }, 2);
        }
    }
}

public class HW1
{
    public static long QueueTime(int[] customers, int n)
    {
        int count = 0, queue = 0, N = n;
        int[] register = new int[n];

        for (int i = 0; i < n; i++)
        {
            register[i] = customers[queue];
            queue++;
        }

        while (queue <= customers.Length)
        {
            for (int i = 0; i < n; i++)
            {
                register[i]--;

                if (register[i] == 0 && queue < customers.Length)
                {
                    register[i] = customers[queue];
                    queue++;
                }
                if (register[i] == 0 && queue == customers.Length)
                    n = 1;
                if (register[i] < 0)
                {
                    queue++;
                    count--;
                }
            }
            count++;
        }

        Console.Write("\n Массив покупателей: ");
        for (int i = 0; i< customers.Length; i++)
        {
            Console.Write(" {0} ", customers[i]);
        }
        Console.WriteLine("\n Количество касс: {0} ", N);
        Console.Write(" Время обслуживания всех покупателей: {0}\n", count);

        return 0;
    }
}
