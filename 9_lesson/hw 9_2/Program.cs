// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int Sum(int n, int m)
{
    if (n > m)
        return 0;
    return n + Sum(n + 1, m);
}
System.Console.WriteLine(Sum(1, 15));