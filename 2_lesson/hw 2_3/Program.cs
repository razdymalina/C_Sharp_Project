// Напишите программу, которая выводит третью цифру
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
void Number(int num)
{
    Console.Write($"{num} -> ");
    if (num < 100)
    {
        Console.WriteLine("третьей цифры нет");
        return;
    }

    while (num > 999) 
    num /= 10;
    Console.WriteLine(num % 10);
}

Number(int.Parse(Console.ReadLine()));
