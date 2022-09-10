//Задача 47

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
// double[,] result = CreateRandomArray(m, n);
// Print2DArray(result);

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// double[,] CreateRandomArray(int m, int n)
// {
//     double[,] array = new double[m, n];
//     Random random = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = Convert.ToDouble(random.Next(-100, 100)/10.0);
//         }
//     }
//     return array;
// }


//Задача 50

// Console.Write("Введите размерность m: ");
// bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

// Console.Write("Введите размерность n: ");
// bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

// Console.Write("Какое число искать: ");
// bool isNumber3 = int.TryParse(Console.ReadLine(), out int number);

// if (!isNumber1 || !isNumber2 || n <= 0 || m <= 0 || !isNumber3)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// Console.WriteLine();
// int[,] result = CreateRandomArray(m, n);

// Print2DArray(result);
// Console.WriteLine();

// int[] resultArrey = FindNumber(result, number);

// if (resultArrey[0] != -1)
// {
//     PrintArray(resultArrey);
// }


// int[] FindNumber(int[,] array, int Number)
// {
//     int[] arrayResult = new int[2];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == Number)
//             {
//                 arrayResult[0] = i;
//                 arrayResult[1] = j;
//                 return arrayResult;
//             }
//         }
//     }
//     Console.WriteLine("нет такого элемента");
//     arrayResult[0] = -1;
//     return arrayResult;
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


//Задача 52

Console.Write("Введите размерность m: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите размерность n: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

if (!isNumber1 || !isNumber2 || n <= 0 || m <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}

Console.WriteLine();
int[,] result = CreateRandomArray(m, n);

Print2DArray(result);
Console.WriteLine();

double[] resultArrey = FindArithmeticMean(result, n);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(resultArrey);


double[] FindArithmeticMean(int[,] result, int n)
{
    double[] array = new double[n];
    for (int i = 0; i < result.GetLength(1); i++)
    {
        double sum = 0;

        for (int j = 0; j < result.GetLength(0); j++)
        {
            sum = sum + result[j, i];
        }
        array[i] = sum / result.GetLength(0);
    }
    return array;
}



int[,] CreateRandomArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }

    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Что-то пошло не так");
        return;
    }

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{Math.Round(array[i], 2)}; ");
    }
    Console.Write(Math.Round(array[array.Length - 1], 2));
    Console.Write(";");
}