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

// bool CheckTri(int a, int b, int c)
// {
//     if (a + b > c && a + c > b && b + c > a)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }

// }


// Console.WriteLine("Первое число:  ");
// bool isNumber1 = int.TryParse(Console.ReadLine(), out int x);
// Console.WriteLine("Первое число:  ");
// bool isNumber2 = int.TryParse(Console.ReadLine(), out int y);
// Console.WriteLine("Первое число:  ");
// bool isNumber3 = int.TryParse(Console.ReadLine(), out int z);

// if (!isNumber1 || !isNumber2 || !isNumber2)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }


// if (CheckTri(x, y, z))
// {
//     Console.WriteLine("Это треугольник");
// }
// else
// {
//     Console.WriteLine("Это не треугольник");
// }




//Задача 44


// int[] GetFib(int N)
// {
    
//     int[] result = new int[N];
//     result[0] = 0;
    
//     if(N<2)
//     {
//         return result;
//     }

//     result[1] = 1;

//     for(int i = 2; i < N; i++)
//     {
//         result[i] = result[i-1] + result[i-2];
//     }
//     return result;
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


// Console.WriteLine("Enter length - ");
// bool isNumber = int.TryParse(Console.ReadLine(), out int length);

// if (!isNumber || length <= 0)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// int[] result = GetFib(length);

// PrintArray(result);


//Задача 45

int[] FillArray(int length)
{
    int[] array = new int[length];
    
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-10, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    if (array.Length == 0)
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

int[] CopyArray(int[] array)
{
    int[] array2 = new int[array.Length];

    for(int i = 0; i < array.Length; i++)
    {
        array2[i] = array[i];
    }
    return array2;
}


Console.WriteLine("Enter length - ");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);

if (!isNumber || length <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}

int[] result = FillArray(length);
PrintArray(result);

Console.WriteLine();

int[] copy = CopyArray(result);

