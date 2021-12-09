﻿using System;

namespace PerfectNumber
{
    class Program
    {
        static bool isPerfect(int n)
        {
            int sum = 1;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (i * i != n)
                        sum = sum + i + n / i;
                    else
                        sum = sum + i;
                }
            }
            if (sum == n && n != 1)
                return true;

            return false;
        }

        // Driver program
        static void Main()
        {
            System.Console.WriteLine("Below are all perfect" +
                                        "numbers till 10000");
            for (int n = 2; n < 10000; n++)
                if (isPerfect(n))
                    System.Console.WriteLine(n +
                            " is a perfect number");
        }
    }
}
