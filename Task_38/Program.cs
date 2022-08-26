// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2, MidpointRounding.ToZero);
    }
    return array;
}

double DiffMaxMinElem(double[] array)
{
    double max1 = array[0];
    double min1 = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max1) max1 = array[i];
        else if (array[i] < min1) min1 = array[i];
    }

    double difference = Math.Round((max1 - min1), 2, MidpointRounding.ToZero);
    return difference;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

double[] arr = CreateArrayRndDouble(5, 0, 100);
PrintArray(arr);
double result = DiffMaxMinElem(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами = {result}");