﻿// Напишите программу, которая будет принимать на вход число и
//возвращать сумму его цифр. Использовать рекурсию.
//453 -> 12
//45 -> 9

int Numbers(int a)
{
    if (a == 0) return 0;
    return Numbers(a / 10) + a % 10;

}
Console.WriteLine(Numbers(453));