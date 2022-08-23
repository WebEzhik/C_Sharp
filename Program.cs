//Задача 10

Random random = new Random();

int number = random.Next(100, 1000);
Console.WriteLine(number);

int GetTooNamber(int N)
{
    int N2 = N % 100;
    int N1 = N2 / 10;
    return N1;
}
// Console.WriteLine(N2);
// Console.WriteLine(N1);

int result = GetTooNamber(number);
Console.WriteLine(result);



//Задача 13

// Console.WriteLine("Введите число:");
// int N1 = Convert.ToInt32(Console.ReadLine());

// int GetThreeNamber(int number)
// {
//     string num = Convert.ToString(number);
//     int ThreeNamber = Convert.ToInt32(num.Substring(2, 1));
//     return ThreeNamber;
// }

// if(N1 > 99 || N1 < -99)
// {
//     int result = GetThreeNamber(N1);
//     Console.WriteLine($"Третье число:{result}");
// }
// else
// {
//     Console.WriteLine("Нет третьего числа.");
// }


//Задача 15

// Console.WriteLine("Введите номер дня недели:");
// int N1 = Convert.ToInt32(Console.ReadLine());

// Boolean CheckOffDay(int N)
// {
//     if(N > 5 && N < 8)
//     {
//        return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// bool result = CheckOffDay(N1);


// if(N1 > 7 || N1 < 1)
// {
//     Console.WriteLine("Такого дня нет:");
// }
// else
// {
//     if(result)
//     {
//         Console.WriteLine("Выходной:");
//     }
//     else
//     {   
//         Console.WriteLine("Будний:");
//     }
// }