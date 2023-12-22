using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] inputArray = { "Telescopes", "Glasses", "Eyes", "Monocles" };

        string[] sortedArray = SortStringsByLength(inputArray);

        Console.WriteLine("Отсортированный массив:");
        foreach (string str in sortedArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] SortStringsByLength(string[] array)
    {
        return array.OrderBy(str => str.Length).ToArray();
    }
}