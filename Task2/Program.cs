// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

int[,] array = new int[3, 7];
Console.WriteLine($"\n Вводный массив: ");

FillArray(array);
PrintArray(array);

int minStringLine = 0;
int sumString = SumStringElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumStringElements(array, i);
    if (sumString > tempSumLine)
    {
        sumString = tempSumLine;
        minStringLine = i;
    }
}

Console.WriteLine($"\n{minStringLine + 1} - строкa с наименьшей суммой ({sumString}) элементов ");


int SumStringElements(int[,] array, int i)
{
    int sumString = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumString += array[i, j];
    }
    return sumString;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}