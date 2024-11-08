using System;

class Program
{
    static void Main()
    {
      
        int[] array = { 38, 46, 8, 32, 79, 98, 15, 5, 57, 20, 41, 12, 73, 23, 6, 18, 90, 26, 72, 50,
                        66, 1, 100, 65, 2, 19, 45, 21, 37, 52, 63, 10, 33, 25, 44, 22, 17, 92, 34, 88,
                        48, 27, 9, 76, 24, 3, 39, 4, 70, 29, 77, 91, 80, 74, 67, 86, 14, 61, 82,
                        62, 84, 95, 59, 13, 54, 7, 16, 81, 40, 99, 68, 36, 35, 60, 11, 97, 83, 93,
                        43, 53, 69, 55, 96, 42, 87, 30, 71, 58, 49, 64, 31, 47, 75, 78,79, 89, 56, 28};

        int missingNumber = FindMissingNumber(array);
        Console.WriteLine("Відсутнє число: " + missingNumber);
    }

    static int FindMissingNumber(int[] array)
    {
        int n = array.Length + 1;
        int totalSum = n * (n + 1) / 2; 
        int arraySum = 0;

        foreach (int num in array)
        {
            arraySum += num;
        }

        return totalSum - arraySum;
    }
}
