using System;
using System.Collections.Generic;
using System.Text;

namespace labs
{
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

            return count;
        }
    }
}
