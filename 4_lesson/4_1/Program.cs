// Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5 

int Count(int n)
{
    if (n == 0)
    {
        return (1);
    }
    int i = 0;
    while (n > 0)
    {
        n = n / 10;
        i++;
    }
    return i;
}
Console.WriteLine(Count(int.Parse(Console.ReadLine())));
