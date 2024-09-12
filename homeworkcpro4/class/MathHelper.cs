using System;

public static class MathHelper
{
    public static int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Число повинно бути невід'ємним.");
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }

    public static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }
}