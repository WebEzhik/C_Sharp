//Задача 67
// Console.Write("n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Recursive(int n, int sum = 0)
// {

//     if (n % 10 > 0)
//     {        
//         n = n / 10;
//         return sum = sum + (n % 10) + Recursive(n, sum);
//     }

// return sum;
// }

// int result = Recursive(n);
// Console.Write(result);



//Задача 69. Возводит число А в степень В с помощью рекурсии

//Проверка вводимого числа 
// Console.Write("Введите число: ");
// bool isNum_a = int.TryParse(Console.ReadLine(), out int a);
// Console.Write("Введите число: ");
// bool isNum_b = int.TryParse(Console.ReadLine(), out int b);
// if (!isNum_a || !isNum_b)
// {
//     Console.WriteLine("Ошибка ввода");
//     return;
// }



// int GetDegreeNumber(int a, int b, int i = 1)
// {
//     if (i <= b)
//     {
//         i++;
//         return a * GetDegreeNumber(a, b, i);
//     }
//     return 1;
// }

// Console.WriteLine(GetDegreeNumber(a, b));


//Вывести значения от М до N

//Проверка вводимого числа 
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