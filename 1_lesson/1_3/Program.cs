﻿//Напишите программу, которая на вход
//принимает одно число (N), а на выходе показывает
//все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число");
String a = Console.ReadLine();
int N = int.Parse(a);
int Negn = -N;
while(Negn <= N)
{
    Console.Write($"{Negn} ");
    Negn +=1;
}