using System;
class task1
{
    static void Main()
    {
        Console.Write("Введите размер бриллианта: ");
        int size = int.Parse(Console.ReadLine());

        string diamond = PrintDiamond(size);

        if (diamond != null)
        {
            Console.WriteLine(diamond);
        }
        else
        {
            Console.WriteLine("Невозможно создать ромб четного или отрицательного размера.");
        }
    }
    static string PrintDiamond(int size)
    {
        if (size <= 0 || size % 2 == 0)
        {

            return null;
        }
        string result = "";
        int middle = size / 2;

        for (int i = 0; i < size; i++)
        {
            int spaces = Math.Abs(middle - i);
            int stars = size - 2 * spaces;

            result += new string(' ', spaces);
            result += new string('*', stars);
            result += "\n";
        }
        return result;
    }
}
