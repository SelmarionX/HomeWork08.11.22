// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить
// // массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();


int[,,] array3D = new int[2, 2, 2];

CreateArray(array3D);
PrintArray(array3D);


void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            // Console.Write($"({i}) ({j}) ");
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                // Console.Write($"({k})={array3D[i, j, k]}; ");
                Console.Write($"{array3D[i, j, k]} ({j},{k},{i})\t");
            }
            Console.WriteLine();
        }
        // Console.WriteLine();
    }
}

void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

// int x = 2;
// int y = 2;
// int z = 2;
// int antiRepeat = 1;
// int startTwoNum = 10;
// Random rand = new Random();
// Console.WriteLine("Трехмерный массив: ");
// int[,,] matrix1 = new int[x, y, z];
// for (int i = 0; i < matrix1.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix1.GetLength(1); j++)
//     {
//         for (int k = 0; k < matrix1.GetLength(2); k++)
//         {
//             matrix1[i, j, k] = startTwoNum + antiRepeat;
//             antiRepeat++;
//             Console.Write($"{matrix1[i, j, k]} ({j},{k},{i})\t");
//         }
//         Console.WriteLine();
//     }
// }