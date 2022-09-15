//Задача 53
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

//     SwapLines(result);
//     Print2DArray(result);

// void SwapLines(int[,] array)
// {
//     int tmp = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         tmp = array[0, j];
//         array[0, j] = array[array.GetLength(0) - 1, j];
//         array[array.GetLength(0) - 1, j] = tmp;
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


//Задача 55

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

// if (result.GetLength(1) == result.GetLength(0))
// {
//     RotateMatrix(result);
//     Print2DArray(result);
// }
// else
// {
//     Console.WriteLine("Не получилось поменять.");
// }



// void RotateMatrix(int[,] array)
// {
//     int tmp = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = i; j < array.GetLength(1); j++)
//         {
//             tmp = array[i, j];
//             array[i, j] = array[j, i];
//             array[j, i] = tmp;
//         }

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


//Задача 57

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

// int[,] FindArray = FindRepeats(result);
// PrintCuontArray(FindArray);



// int[,] FindRepeats(int[,] array)
// {
//     int[,] arrayCount = new int[2, array.GetLength(0) * array.GetLength(1)];

//     int numCount = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             bool isExist = false;
//             for (int y = 0; y < arrayCount.GetLength(1); y++)
//             {
//                 if (arrayCount[0, y] == array[i, j])
//                 {
//                     arrayCount[1, y] = arrayCount[1, y] + 1;
//                     isExist = true;
//                     break;
//                 }
//             }
//             if (!isExist)
//             {
//                 arrayCount[0, numCount] = array[i, j];
//                 arrayCount[1, numCount] = 1;
//                 numCount++;
//             }
//         }
//     }
//     return arrayCount;
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


// void PrintCuontArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {

//         if (array[1, i] == 0)
//         {
//             return;
//         }

//         Console.Write($"{array[0, i]} встречается: {array[1, i]} раз");

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

//Задача 59


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

// int[] minArr = FindMin(result);
// PrintArray(minArr);



// int[,] resultArr = DelRowCol(result, minArr);

// int[,] DelRowCol(int[,] array, int[] minArr)
// {
//     int[] resultArr = new int[array.GetLength(0)-1, array.GetLength(0)-1];
//     resultArrI = 0;
//     resultArrJ = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//         }

//     }
// }

// int[] FindMin(int[,] array)
// {
//     int min = array[0, 0];
//     int[] minInd = new int[2];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (min < array[i, j])
//             {
//                 min = array[i, j];
//                 minInd[0] = i;
//                 minInd[1] = j;
//             }
//         }
//     }
//     return minInd;
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

// void PrintArray(int[] array)
// {
//     if (array.Length == 0)
//     {
//         Console.WriteLine("Что-то пошло не так");
//         return;
//     }
//     Console.Write("[");

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]},");
//     }

//     Console.Write(array[array.Length - 1]);
//     Console.Write("]");
// }