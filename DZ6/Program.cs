//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Write("Введите число М:  ");
// bool isNumber = int.TryParse(Console.ReadLine(), out int M);



// if (!isNumber || M <= 0)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// int result = InputNumbers(M);
// Console.WriteLine($"Положительных чисел: {result}");


// int InputNumbers(int M)
// {
//     int count = 0;
//     for (int i = 1; i <= M; i++)
//     {
//         Console.Write($"Введите {i} число:  ");
//         bool isNumber = int.TryParse(Console.ReadLine(), out int Number);
//         if (!isNumber)
//         {
//             Console.WriteLine("Это не число. Введите снова.");
//             i--;
//         }
//         if(Number > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите число k1:  ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int k1);
Console.Write("Введите число b1:  ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int b1);
Console.Write("Введите число k2:  ");
bool isNumber3 = int.TryParse(Console.ReadLine(), out int k2);
Console.Write("Введите число b2:  ");
bool isNumber4 = int.TryParse(Console.ReadLine(), out int b2);


if (!isNumber1 || !isNumber2 || !isNumber3 || !isNumber4)
{
    Console.WriteLine("Invalid number");
    return;
}

double[] result = FindPoint(k1, b1, k2, b2);

PrintArray(result);

double[] FindPoint(double k1, double b1, double k2, double b2)
{
    double[] arrey = new double[2];
    if(k1 == k2 || (k1 - k2) == b1)
    {
        Console.WriteLine("Прямые не пересекаются");
        return arrey;
    }
    else
    {
        arrey[0] = (b2-b1)/(k1-k2);
        arrey[1] = k1*(b2-b1)/(k1-k2) + b1;
    }
    return arrey;
}


void PrintArray(double[] array)
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