// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.(посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();


int m = 2;
int n = 2;
int p = 2;

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void CreateArray(int[,] array)
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


// int line = 2;
// int columns = 2;
// Random rand = new Random();
// Console.WriteLine("Первая матрица: ");
// int[,] matrix1 = new int[line, columns];
// for (int i = 0; i < matrix1.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix1.GetLength(1); j++)
//     {
//         matrix1[i, j] = rand.Next(1, 9);
//         Console.Write($"{matrix1[i, j]}\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("\nВторая матрица: ");
// int[,] matrix2 = new int[line, columns];
// for (int i = 0; i < matrix2.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix2.GetLength(1); j++)
//     {
//         matrix2[i, j] = rand.Next(1, 9);
//         Console.Write($"{matrix2[i, j]}\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("\nПроизведение двух матриц: ");
// int[,] matrix3 = new int[line, columns];
// for (int i = 0; i < matrix1.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix2.GetLength(1); j++)
//     {
//         for (int k = 0; k < matrix2.GetLength(0); k++)
//         {
//             matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
//         }
//         Console.Write($"{matrix3[i, j]}\t");
//     }
//     Console.WriteLine();
// }