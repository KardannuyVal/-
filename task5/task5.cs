using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();
        string[] inputNumbers = input.Split(' ');
        int[] numbers = new int[inputNumbers.Length];
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            if (int.TryParse(inputNumbers[i], out int number))
            {
                numbers[i] = number;
            }
            else
            {
                Console.WriteLine($"Ошибка ввода: '{inputNumbers[i]}' не является целым числом.");
                return;
            }
        }
        int? result = FindNearestToZero(numbers);
        if (result.HasValue)
        {
            Console.WriteLine($"Ближайшее к нулю значение: {result}");
        }
        else
        {
            Console.WriteLine("Невозможно определить только одно значение.");
        }
    }
    static int? FindNearestToZero(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return null;

        int closestToZero = numbers[0];

        foreach (int number in numbers)
        {
            if (Math.Abs(number) < Math.Abs(closestToZero))
            {
                closestToZero = number;
            }
            else if (Math.Abs(number) == Math.Abs(closestToZero) && number > closestToZero)
            {
                closestToZero = number;
            }
        }
        return closestToZero;
    }
}
