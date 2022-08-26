// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] array = new int [4];
FillArray(array, 100, 998);
PrintArray(array);
FindEven(array);

void FillArray(int [] array, int StartNum = -10, int FinishNum = 10)
{
    FinishNum++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(StartNum,FinishNum);
    }
}
void PrintArray(int [] array)
{   
    for (int i = 0;i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
        Console.WriteLine();
}
void FindEven(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if(array[i]%2 == 0)
        count ++;
    }
    Console.WriteLine("Колличество четных числе в массиве = " + count);
}
