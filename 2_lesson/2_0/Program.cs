// Напишите программу, которая выводит случайное
//число из отрезка [10, 99] и показывает наибольшую
//цифру числа.

int Maxnumber(int num)
{
    Console.WriteLine(num);

    if (num % 10 > num / 10)
        return num % 10;
    else 
        return num / 10;
}
//123456 % 10 -> 6
//123456 / 10 -> 12345

Console.WriteLine(Maxnumber(new Random().Next(10, 100)));