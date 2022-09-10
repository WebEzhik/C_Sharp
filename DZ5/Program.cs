
//Задача 34
// int[] FillArray(int length)
// {
//     int[] array = new int[length];
    
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = random.Next(100, 1000);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     if(array.Length == 0)
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

// int CheckArray(int[] array)
// {
    
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//         {
//             result++;
//         }
//     }
//     return result;
// }


// // Console.Write("Размер массива: ");
// // bool isNumber = int.TryParse(Console.ReadLine(), out int length);

// // if (!isNumber || length <= 0)
// // {
// //     Console.WriteLine("Invalid number");
// //     return;
// // }

// int length = 12;

// int[] array = FillArray(length);
// PrintArray(array);

// int result = CheckArray(array);
// Console.WriteLine();
// Console.Write($"Количество элементов: {result}");




//Задача 36


// int[] FillArray(int length)
// {
//     int[] array = new int[length];
    
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = random.Next(0, 11);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     if(array.Length == 0)
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

// int SumArray(int[] array)
// {
    
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i % 2 == 1)
//         {
//             result = result + array[i];
//         }
//     }
//     return result;
// }


// // Console.Write("Размер массива: ");
// // bool isNumber = int.TryParse(Console.ReadLine(), out int length);

// // if (!isNumber || length <= 0)
// // {
// //     Console.WriteLine("Invalid number");
// //     return;
// // }

// int length = 4;

// int[] array = FillArray(length);
// PrintArray(array);

// int result = SumArray(array);

// Console.Write($"Сумма элементов: {result}");


//Задача 38



int[] FillArray(int length)
{
    int[] array = new int[length];
    
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(1, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    if(array.Length == 0)
    {
        Console.WriteLine("Что-то пошло не так");
        return;
    }
    Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }

    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int GetMax(int[] array)
{
    
    int result = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > result)
        {
            result = array[i];
        }
    }
    return result;
}

int GetMin(int[] array)
{
    
    int result = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < result)
        {
            result = array[i];
        }
    }
    return result;
}


// Console.Write("Размер массива: ");
// bool isNumber = int.TryParse(Console.ReadLine(), out int length);

// if (!isNumber || length <= 0)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

int length = 4;

int[] array = FillArray(length);
PrintArray(array);

int min = GetMin(array);
int max = GetMax(array);

Console.Write($"Разность между максимальным и минимальным элементами: {max - min}");