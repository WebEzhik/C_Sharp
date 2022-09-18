//Задача 64

// //Проверка вводимого числа 
// Console.Write("Введите число: ");
// bool isNum_m = int.TryParse(Console.ReadLine(), out int m);
// Console.Write("Введите число: ");
// bool isNum_n = int.TryParse(Console.ReadLine(), out int n);
// if (!isNum_m || !isNum_n)
// {
//     Console.WriteLine("Ошибка ввода");
//     return;
// }

// int[] array = new int[n - m + 1];
// int i = 0;
// int[] Recursive(int m, int n)
// {
//     if (m <= n)
//     {
//         array[i] = m;
//         m++;
//         i++;
//         Recursive(m, n);
//     }
//     return array;
// }

// //Печать массива
// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//     {
//         Console.Write($"{item} ");
//     }
// }

// PrintArray(Recursive(m, n));

//Задача 66

// //Проверка вводимого числа 
// Console.Write("Введите число: ");
// bool isNum_m = int.TryParse(Console.ReadLine(), out int m);
// Console.Write("Введите число: ");
// bool isNum_n = int.TryParse(Console.ReadLine(), out int n);
// if (!isNum_m || !isNum_n)
// {
//     Console.WriteLine("Ошибка ввода");
//     return;
// }

// Console.WriteLine($"Сумма чисел равна: {Recursive(m, n)}");

// int Recursive(int m, int n, int sum = 0)
// {

//     if (m <= n)
//     {
//         sum = sum + m;
//         return Recursive(m + 1, n, sum);
//     }
//     return sum;
// }


//Задача 68

//Проверка вводимого числа 
Console.Write("Введите число n: ");
bool isNum_m = int.TryParse(Console.ReadLine(), out int n);
Console.Write("Введите число m: ");
bool isNum_n = int.TryParse(Console.ReadLine(), out int m);
if (!isNum_m || !isNum_n)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

Console.WriteLine($"Функция Аккермана равна: {Recursive(n, m)}");

int Recursive(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (n != 0 && m == 0)
    {
        return Recursive(n - 1, 1);
    }
    if (n > 0 && m > 0)
    {
        return Recursive(n - 1, Recursive(n, m - 1));
    }
    return Recursive(n, m);
}


