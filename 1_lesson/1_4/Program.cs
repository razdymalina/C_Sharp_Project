// Напишите программу вычисления
//модуля числа.
//6 -> 6
//-82 -> 82

Console.Write("Введите число:");
var s = Console.ReadLine();
int N = s == null ? 0 :int.Parse(s);
Console.WriteLine($"{Math.Abs(N)}");