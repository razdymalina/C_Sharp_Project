// Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "2, 4"
//N = 8 -> "2, 4, 6, 8"

void Numbers(int m, int n)
{
    if (m > n) return;

    if (m % 2 == 0)
    {
        Console.Write($" {m} ");
        Numbers(m + 2, n);
    }
    else
    {
        m += 1;
        Console.Write($" {m} ");
        Numbers(m + 2, n);
    }
}
Console.WriteLine("Enter Numbers: ");
Numbers(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));