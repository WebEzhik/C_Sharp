//Задача 25
Console.WriteLine("Введите число А: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int a);

Console.WriteLine("Введите число B: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int b);

if (!isNumber1 || !isNumber2)
{
    Console.WriteLine("Не число");
    return;
}

int GetDegree(int A, int B)
{
    if(B == 0)
    {
        return 1;
    }
    
    int result = 1;
    for(int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

int result = GetDegree(a, b);
Console.WriteLine(result);


//Задача 27
// Console.WriteLine("Введите число N: ");
// bool isNumber = int.TryParse(Console.ReadLine(), out int n);

// if (!isNumber)
// {
//     Console.WriteLine("Не число");
//     return;
// }

// int GetSumNumber(int number)
// {
//     int sum = 0;
//     while(number != 0)
//     {
//         sum = sum + (number % 10);
//         number = number / 10;
//         //Console.WriteLine(number);
//     }
//     return sum;
// }
// int result = GetSumNumber(n);

// Console.WriteLine(result);



//Задача 29

// void PrintSqares(int[] sqares)
// {
//     int i = 0;
//     int Len = sqares.Length;
//     while (i < Len)
//     {
//         Console.Write($" {sqares[i]}");
//         i++;
//     }
// }

// int[] GenrArrey(int N)
// {
//     int[] arr = new int[N];

//     for (int i = 0; i < N; i++)
//     {
//         Console.WriteLine($"Введите {i+1} элемент массива: ");

//         bool isNumber = int.TryParse(Console.ReadLine(), out int n);

//         if (!isNumber)
//         {
//             Console.WriteLine("Не число");
//             i--;
//         }
//         else{
//             arr[i] = n;
//         }
//     }
//     return arr;
// }

// Console.WriteLine("Введите размерность массива: ");
// bool isNumber = int.TryParse(Console.ReadLine(), out int n);

// if (!isNumber)
// {
//     Console.WriteLine("Не число");
//     return;
// }
// PrintSqares(GenrArrey(n));






