// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

string Pal(int a)
{  
    int num = 10000;
    if (a > 100000 || a < 10000)
        return "Число не палиндром";
    else        
        while (num > 1)
        {
            if (a / num % 10 != a % 10)
                return "нет";
            a /= 10;
            num /= 100;
        }    
        return "да";
}

Console.WriteLine(Pal(int.Parse(Console.ReadLine())));
