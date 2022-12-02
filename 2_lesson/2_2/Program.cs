// Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//программа выводит остаток от деления.
//● 34, 5 -> не кратно, остаток 4
//● 16, 4 -> кратно 

string Num(int num1, int num2)
{
    if (num1 % num2 == 0)
        return "кратно";
    else 
        return $"некратно, остаток = {num1 % num2}";
}
Console.WriteLine("first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("second number");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(Num(a, b));