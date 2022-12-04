// Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру от 1 до 7");
void Num(int num)
{
    string text = "будний";

    if (num == 7 || num == 6) text = "выходной";
    Console.WriteLine($"{num} -> {text}");
}

Num(int.Parse(Console.ReadLine()));