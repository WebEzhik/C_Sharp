//Задача 54

// Console.Write("Введите размерность m: ");
// bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

// Console.Write("Введите размерность n: ");
// bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

// if (!isNumber1 || n <= 0 || m <= 0 || !isNumber2)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// Console.WriteLine();
// int[,] result = CreateRandomArray(m, n);
// Print2DArray(result);

// Console.WriteLine();
// SortArray(result);
// Print2DArray(result);

// void SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             for (int n = 0; n < array.GetLength(1) - j - 1; n++)
//             {
//                 if (array[i,n] < array[i,n + 1])
//                 {
//                     int temp = array[i,n];
//                     array[i,n] = array[i,n + 1];
//                     array[i,n + 1] = temp;
//                 }
//             }
//     }
// }


// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] CreateRandomArray(int m, int n)
// {
//     int[,] array = new int[m, n];

//     Random random = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(0, 10);
//         }
//     }

//     return array;
// }


//Задача 56

// Console.Write("Введите размерность m: ");
// bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

// Console.Write("Введите размерность n: ");
// bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

// if (!isNumber1 || n <= 0 || m <= 0 || !isNumber2)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// Console.WriteLine();
// int[,] result = CreateRandomArray(m, n);
// Print2DArray(result);

// Console.WriteLine();

// Console.WriteLine($"Строка с минимальной суммой: {GetMinLineArray(result)}");


// int GetMinLineArray(int[,] array)
// {
//     int minLine = 10000;
//     int indexMinLine = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sumLine = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sumLine = sumLine + array[i, j];
//         }

//         if (minLine > sumLine)
//         {
//             minLine = sumLine;
//             indexMinLine = i;
//         }
//     }
//     indexMinLine++;
//     return indexMinLine;
// }


// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] CreateRandomArray(int m, int n)
// {
//     int[,] array = new int[m, n];

//     Random random = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(0, 10);
//         }
//     }

//     return array;
// }


//Задача 58

// Console.WriteLine("Первая матрица: ");
// Console.Write("Введите размерность m: ");
// bool isNumber1 = int.TryParse(Console.ReadLine(), out int m1);

// Console.Write("Введите размерность n: ");
// bool isNumber2 = int.TryParse(Console.ReadLine(), out int n1);

// if (!isNumber1 || n1 <= 0 || m1 <= 0 || !isNumber2)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// Console.WriteLine();
// int[,] result1 = CreateRandomArray(m1, n1);
// Print2DArray(result1);

// Console.WriteLine();

// Console.WriteLine("Вторая матрица: ");
// Console.Write("Введите размерность m: ");
// bool isNumber3 = int.TryParse(Console.ReadLine(), out int m2);

// Console.Write("Введите размерность n: ");
// bool isNumber4 = int.TryParse(Console.ReadLine(), out int n2);

// if (!isNumber3 || n2 <= 0 || m2 <= 0 || !isNumber4)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// int[,] result2 = CreateRandomArray(m2, n2);
// Print2DArray(result2);

// Console.WriteLine();

// int[,] multMatrix = multiplicationMatrix(result1, result2);

// if (multMatrix[0, 0] == 3546534)
// {
//     Console.Write("Матрицы нельзя перемножить:");
// }
// else
// {
//     Console.WriteLine("Произведение матриц:");
//     Print2DArray(multMatrix);
// }




// int[,] multiplicationMatrix(int[,] array1, int[,] array2)
// {

//     int[,] multMatrix = new int[array1.GetLength(0), array2.GetLength(1)];

//     if (array1.GetLength(1) != array2.GetLength(0))
//     {
//         multMatrix[0, 0] = 3546534;
//         return multMatrix;
//     }

//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             for (int k = 0; k < array2.GetLength(0); k++)
//             {
//                 multMatrix[i, j] += array1[i, k] * array2[k, j];
//             }
//         }
//     }
//     return multMatrix;
// }


// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] CreateRandomArray(int m, int n)
// {
//     int[,] array = new int[m, n];

//     Random random = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(0, 10);
//         }
//     }

//     return array;
// }


//Задача 60


// Console.Write("Введите размерность x: ");
// bool isNumber1 = int.TryParse(Console.ReadLine(), out int x);

// Console.Write("Введите размерность y: ");
// bool isNumber2 = int.TryParse(Console.ReadLine(), out int y);

// Console.Write("Введите размерность z: ");
// bool isNumber3 = int.TryParse(Console.ReadLine(), out int z);

// if (!isNumber1 || x <= 0 || y <= 0 || z <= 0 || !isNumber2 || !isNumber3)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }
// Console.WriteLine();

// if (x * y * z > 90)
// {
//     Console.WriteLine("Слишком большой массив.");
//     Environment.Exit(0);
// }

// int[,,] result = CreateRandomArray3D(x, y, z);
// Print3DArray(result);
// Console.WriteLine();

// Print3DArrayIndex(result);



// void Print3DArrayIndex(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }


// void Print3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// int[,,] CreateRandomArray3D(int x, int y, int z)
// {
//     int[,,] array = new int[x, y, z];

//     Random random = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 int N = random.Next(10, 100);

//                 while (getUnicNumbers(array, N))
//                 {
//                     N = random.Next(10, 100);
//                 }

//                 array[i, j, k] = N;
//             }
//         }
//     }

//     return array;
// }

// bool getUnicNumbers(int[,,] array, int N)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] == N)
//                 {
//                     return true;
//                 }
//             }
//         }
//     }
//     return false;
// }


//Задача 62

Console.Write("Введите размерность x: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int x);


if (!isNumber1 || x <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}
Console.WriteLine();

Print2DArray(GetSpire(x));

int[,] GetSpire(int n)
{
    int[,] result = new int[n, n];
    int num = 1;

    //Заполнение периметра
    for (int y = 0; y < n; y++)
    {
        result[0, y] = num;
        num++;
    }
    for (int x = 1; x < n; x++)
    {
        result[x, n - 1] = num;
        num++;
    }
    for (int y = n - 2; y >= 0; y--)
    {
        result[n - 1, y] = num;
        num++;
    }
    for (int x = n - 2; x > 0; x--)
    {
        result[x, 0] = num;
        num++;
    }

    //координаты следующей ячейка
    int c = 1;
    int d = 1;

    while (num < n * n)
    {

        while (result[c, d + 1] == 0)
        {
            result[c, d] = num;
            num++;
            d++;
        }

        while (result[c + 1, d] == 0)
        {
            result[c, d] = num;
            num++;
            c++;
        }

        while (result[c, d - 1] == 0)
        {
            result[c, d] = num;
            num++;
            d--;
        }

        while (result[c - 1, d] == 0)
        {
            result[c, d] = num;
            num++;
            c--;
        }
    }

    //Заполнение центра
    for (int x = 0; x < n; x++)
    {
        for (int y = 0; y < n; y++)
        {
            if (result[x, y] == 0)
            {
                result[x, y] = num;
            }
        }
    }

    return result;
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write($"0{array[i, j]} ");
            }
            else
            {
                Console.Write($"{array[i, j]} ");
            }

        }
        Console.WriteLine();
    }
}