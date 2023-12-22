using System;

public static class ArrayExtensions
{
    public static int[] Square(this int[] array)
    {
        int[] newArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i] * array[i];
        }
        return newArray;
    }

    public static int[] Cube(this int[] array)
    {
        int[] newArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i] * array[i] * array[i];
        }
        return newArray;
    }

    public static double Average(this int[] array)
    {
        if (array.Length == 0)
        {
            return double.NaN;
        }
        return (double)array.Sum() / array.Length;
    }

    public static int Sum(this int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    public static int[] Even(this int[] array)
    {
        int[] newArray = new int[array.Length];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                newArray[count++] = array[i];
            }
        }
        Array.Resize(ref newArray, count);
        return newArray;
    }

    public static int[] Odd(this int[] array)
    {
        int[] newArray = new int[array.Length];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 1)
            {
                newArray[count++] = array[i];
            }
        }
        Array.Resize(ref newArray, count);
        return newArray;
    }

    public static void Main()
    {
        // Ввод массива от пользователя
        Console.Write("Введите элементы массива через пробел: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] a = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            if (int.TryParse(input[i], out int value))
            {
                a[i] = value;
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Введите целочисленные значения.");
                return;
            }
        }

        // Вызов методов
        int[] squared = a.Square();
        int[] cubed = a.Cube();
        double average = a.Average();
        int sum = a.Sum();
        int[] even = a.Even();
        int[] odd = a.Odd();

        // Вывод результатов
        Console.WriteLine("Squared: " + string.Join(", ", squared));
        Console.WriteLine("Cubed: " + string.Join(", ", cubed));
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Even: " + string.Join(", ", even));
        Console.WriteLine("Odd: " + string.Join(", ", odd));
    }
}