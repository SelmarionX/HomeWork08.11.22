// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.(посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();

Console.WriteLine("\n" + "Задача 58." + "\n");
int line = 2;
int columns = 2;
Random rand = new Random();
Console.WriteLine("Первый массив: ");
int[,] matrix1 = new int[line, columns];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i, j] = rand.Next(1, 9);
        Console.Write($"{matrix1[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine("\nВторой массив: ");
int[,] matrix2 = new int[line, columns];
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i, j] = rand.Next(1, 9);
        Console.Write($"{matrix2[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine("\nПроизведение массивов: ");
int[,] matrix3 = new int[line, columns];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix2.GetLength(0); k++)
        {
            matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
        }
        Console.Write($"{matrix3[i, j]}\t");
    }
    Console.WriteLine();
}