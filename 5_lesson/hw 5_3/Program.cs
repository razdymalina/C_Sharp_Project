// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)    
        Console.Write($"{arr[i]} ");
    
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)    
        arr[i] = Math.Round(n_new.NextDouble(), 2);
    
    return arr;
}

void Diff(double[] arr)
{
    double n_max = arr[0];
    double n_min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (n_max < arr[i])        
            n_max = arr[i];
        
        else if (n_min > arr[i])        
            n_min = arr[i];        
    }

    Console.Write($"Максимальное: {n_max}, минимальное: {n_min}. ");
    Console.WriteLine($"Разница = {Math.Round(n_max - n_min)}");
}

double[] arr_1 = MassNums(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
Print(arr_1);
Diff(arr_1);