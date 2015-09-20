using System;
using System.Threading;
using System.Globalization;

class NumberCalculations
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("What type of nubers will be calculated(double, decimal or int):");
        string choice = Console.ReadLine();
        Console.WriteLine();
        if (choice == "double")
        {
            Console.WriteLine("Enter the numbers in one line, separated by a space: ");
            string doubleValues = Console.ReadLine();
            string[] doubleItems = doubleValues.Split(' ');
            double[] doubles = new double[doubleItems.Length];
            for (int i = 0; i < doubleItems.Length; i++)
            {
                doubles[i] = double.Parse(doubleItems[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}, Average: {3}, Product: {4}",
                GetMin(doubles), GetMax(doubles), GetSum(doubles), GetAverage(doubles), GetProduct(doubles));
        }
        if (choice == "decimal" || choice == "int")
        {
            Console.WriteLine("Enter the numbers in one line, separated by a space: ");
            string decimalValues = Console.ReadLine();
            string[] decimalItems = decimalValues.Split(' ');
            decimal[] decimals = new decimal[decimalItems.Length];
            for (int i = 0; i < decimalItems.Length; i++)
            {
                decimals[i] = int.Parse(decimalItems[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}, Average: {3}, Product: {4}",
                GetMin(decimals), GetMax(decimals), GetSum(decimals), GetAverage(decimals), GetProduct(decimals));
        }
    }
    static decimal GetMin(decimal[] numbers)
    {
        decimal min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min) min = numbers[i];
        }
        return min;
    }
    static double GetMin(double[] numbers)
    {
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min) min = numbers[i];
        }
        return min;
    }
    static decimal GetMax(decimal[] numbers)
    {
        decimal max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max) max = numbers[i];
        }
        return max;
    }
    static double GetMax(double[] numbers)
    {
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max) max = numbers[i];
        }
        return max;
    }
    static decimal GetSum(decimal[] numbers)
    {
        decimal sum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static double GetSum(double[] numbers)
    {
        double sum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static decimal GetAverage(decimal[] numbers)
    {
        return GetSum(numbers) / numbers.Length;
    }
    static double GetAverage(double[] numbers)
    {
        return GetSum(numbers) / numbers.Length;
    }
    static decimal GetProduct(decimal[] numbers)
    {
        decimal product = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
    static double GetProduct(double[] numbers)
    {
        double product = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}