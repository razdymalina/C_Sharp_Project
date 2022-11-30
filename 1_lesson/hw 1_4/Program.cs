// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Write a number");
int a = int.Parse(Console.ReadLine());
int count = 2;

if(a == 1)
{
    Console.WriteLine("Четных чисел нет");
}   
while (count <= a)
{
    Console.WriteLine($"{count}");
    count +=2;
}    
Console.WriteLine();