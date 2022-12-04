// Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

string Number (int num)
{
     Console.WriteLine(num);
     return $"{num / 10 % 10}";
}  

Console.WriteLine(Number(new Random().Next(100, 999)));
