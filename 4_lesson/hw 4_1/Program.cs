// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

double Step(int a, int b)
{
    double st = 1;
    for (int i = 1; i <= b; i++)
        st *= a;
    return st;
}

int num_1 = int.Parse(Console.ReadLine());
int num_2 = int.Parse(Console.ReadLine());

Console.WriteLine(Step(num_1, num_2));