// Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого числа.
//645 -> 65
//782 -> 72
//918 -> 98

string Number (int num)
{
     Console.WriteLine(num);
     return $"{num} -> {num / 100}{num % 10}";  
}  

Console.WriteLine(Number(new Random().Next(100, 999)));
