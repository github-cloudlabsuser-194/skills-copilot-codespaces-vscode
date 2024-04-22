using System;

class Program
{
    const int MAX = 100;

    /// <summary>
    /// Sums up all the elements in the array.
    /// </summary>
    /// <param name="arr">The array of integers.</param>
    /// <returns>The sum of all elements.</returns>
    static int Sum(int[] arr)
    {
        int result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }
        return result;
    }

    /// <summary>
    /// Reads an integer from the console.
    /// </summary>
    /// <param name="prompt">The prompt to display.</param>
    /// <returns>The integer read.</returns>
    static int ReadInt(string prompt)
    {
        Console.Write(prompt);
        if (!int.TryParse(Console.ReadLine(), out int result))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Environment.Exit(1);
        }
        return result;
    }

    static void Main()
    {
        int n = ReadInt("Enter the number of elements (1-100): ");
        if (n < 1 || n > MAX)
        {
            Console.WriteLine("Invalid input. Please provide a digit ranging from 1 to 100.");
            Environment.Exit(1);
        }

        int[] arr = new int[n];

        Console.WriteLine($"Enter {n} integers:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = ReadInt($"Enter integer {i+1}: ");
        }

        int total = Sum(arr);

        Console.WriteLine($"Sum of the numbers: {total}");
    }
}