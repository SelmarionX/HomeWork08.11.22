// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Console.Clear();

int n = 4;

double[,] pascalTriangle = new double[n + 1, 2 * n + 1];

FillPascalTriangle(pascalTriangle);

PrintArray(pascalTriangle); // выводим значения в строки треугольника Паскаля,если убрать этот код, то выведем сразу треугольник.

AssemblingPascalTriangle(pascalTriangle);
Console.WriteLine(); // пробел между строками значений и треугольником

PrintArray(pascalTriangle); // выводим собранные значения строк треугольника Паскаля в треугольник

void AssemblingPascalTriangle(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            if (array[i, j] != 0)
            {
                array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
                array[i, j] = 0;
                count++;
            }
        }
    }
    array[array.GetLength(0) - 1, 0] = 1;
}

void FillPascalTriangle(double[,] pascalTriangle)
{
    for (int k = 0; k < pascalTriangle.GetLength(0); k++)
    {
        pascalTriangle[k, 0] = 1;
    }
    for (int i = 1; i < pascalTriangle.GetLength(0); i++)
    {
        for (int j = 1; j < i + 1; j++)
        {
            pascalTriangle[i, j] = pascalTriangle[i - 1, j] + pascalTriangle[i - 1, j - 1];
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0)
            {
                Console.Write($"{array[i, j]} ");
            }
            else Console.Write("  ");
        }
        Console.WriteLine();
    }
}
