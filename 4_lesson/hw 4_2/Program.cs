// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int SumNum(int num)
{
    int num_sum = 0;

    while (num > 0)
    {
        num_sum += num % 10;
        num /= 10;
    }
    return num_sum;
}

Console.WriteLine(SumNum(int.Parse(Console.ReadLine())));