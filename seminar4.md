//Задача 26
Console.WriteLine("Введите число N: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int N);

if (!isNumber)
{
    Console.WriteLine("Не число");
    return;
}

int GetLenNumber(int number)
{
    int count = 0;

    while(number > 0)
    {
        count++;
        number = number / 10;
        //Console.WriteLine(number);
    }
    return count;
}
int result = GetLenNumber(N);
Console.WriteLine(result);



//Задача 28
// Console.WriteLine("Введите число N: ");
// bool isNumber = int.TryParse(Console.ReadLine(), out int n);

// if (!isNumber)
// {
//     Console.WriteLine("Не число");
//     return;
// }

// int GetPrNumber(int number)
// {
//     int result = 1;
//     for(int i = 1; i <= number; i++)
//     {
//         result = result * i;
//     }
//     return result;
// }

// Console.WriteLine(GetPrNumber(n));



//Задача 30

// void PrintSqares(int[] sqares)
// {
//     int i = 0;
//     int Len = sqares.Length;
//     while (i < Len)
//     {
//         Console.WriteLine(sqares[i]);
//         i++;
//     }
// }

// int[] GenrArrey(int N)
// {
//     int[] arr = new int[N];

//     Random random = new Random();

//     int number = random.Next(0, 2);

//     for(int i = 0; i < N; i++)
//     {
//         arr[i] = random.Next(0, 2);
//     }
//     return arr;
// }

// PrintSqares(GenrArrey(8));
















// Задача 19
// Console.WriteLine("Введите пятизначное N: ");
// bool isNumber = int.TryParse(Console.ReadLine(), out int N);


// if (!isNumber)
// {
//     Console.WriteLine("Не число");
//     return;
// }

// int[] GetIntToArr(int Num, int N)
// {
//     int i = 0;
//     int[] arr = new int[N];
//     while (Num > 0)
//     {
//         arr[i] = Num % 10;
//         Num = Num / 10;        
//         //Console.WriteLine(arr[i]);
//         i++;
//     }
//     return arr;
// }

// bool ChekPal(int[] arr)
// {
//     bool result = true;
//     for(int i = 0; i < (arr.Length / 2); i++)
//     {
//         if(arr[i] != arr[arr.Length - i - 1])
//         {
//             result = false;
//         }
//         else
//         {
//             result = true;
//         }
//     }
//     return result;
// }

// int GetLenNumber(int NLen)
// {
//     int ILen = 0;

//     while(NLen > 0)
//     {
//         ILen++;
//         NLen = NLen / 10;
//     }
//     return ILen;
// }

// int Len = GetLenNumber(N);

// int[] arrN = GetIntToArr(N, Len);

// if (ChekPal(arrN))
// {
//     Console.WriteLine("Палиндром.");
// }
// else
// {
//     Console.WriteLine("Не палиндром.");
// }







//Задача 21

// System.Console.Write("Введите координату x первой точки: ");
// bool isNumberX_1 = int.TryParse(Console.ReadLine(), out int x1);
// System.Console.Write("Введите координату y первой точки: ");
// bool isNumberY_1 = int.TryParse(Console.ReadLine(), out int y1);
// System.Console.Write("Введите координату z первой точки: ");
// bool isNumberZ_1 = int.TryParse(Console.ReadLine(), out int z1);

// System.Console.Write("Введите координату x второй точки: ");
// bool isNumberX_2 = int.TryParse(Console.ReadLine(), out int x2);
// System.Console.Write("Введите координату y второй точки: ");
// bool isNumberY_2 = int.TryParse(Console.ReadLine(), out int y2);
// System.Console.Write("Введите координату z второй точки: ");
// bool isNumberZ_2 = int.TryParse(Console.ReadLine(), out int z2);

// if(!isNumberX_1 || !isNumberY_1 || !isNumberZ_1 || !isNumberX_2 || !isNumberY_2 || !isNumberZ_2)
// {
//     Console.WriteLine("Числа введены не верно.");
//     return;
// }


// System.Console.Write($"Расстояние: {GetLenght(x1, y1, z1, x2, y2, z2)}");

// double GetLenght(int x_1, int y_1, int z_1, int x_2, int y_2, int z_2)
// {
//    return Math.Sqrt(Math.Pow((x_2 - x_1), 2) + Math.Pow((y_2 - y_1), 2) + Math.Pow((z_2 - z_1), 2));
// }




//Задача 23

// Console.WriteLine("Введите число N: ");
// bool isNumber = int.TryParse(Console.ReadLine(), out int N);

// int N_abs = Math.Abs(N);

// PrintSqares (GetCub(N_abs));

// int[] GetCub(int n)
// {
//     int i = 1;
//     int[] results = new int[n];
//     while (i <= n)
//     {
//         results[i-1] = (int) Math.Pow (i,3);
//         i++;
//     }
//     return results;
// }

// void PrintSqares(int[] sqares)
// {
//     int i = 0;
//     int Len = sqares.Length;
//     while (i < Len)
//     {
//         Console.WriteLine(sqares[i]);
//         i++;
//     }
// }