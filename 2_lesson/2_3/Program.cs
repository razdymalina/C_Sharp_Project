//Напишите программу, которая принимает на вход
//число и проверяет, кратно ли оно одновременно
//7 и 23.
//● 14 -> нет
//● 46 -> нет
//● 161 -> да 

string Num(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
        return "кратно";
    else 
        return "некратно";
}
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(Num(a));