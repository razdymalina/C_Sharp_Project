﻿// Напишите программу, которая выводит случайное
//трехзначное число и на выходе показывает
//последнюю цифру этого числа.

int Number (int num)
{
     Console.WriteLine(num);
     return num % 10;
}  

Console.WriteLine(Number(new Random().Next(100, 1000)));