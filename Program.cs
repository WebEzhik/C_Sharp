//Задача 11

// Random random = new Random();

// int number = random.Next(100, 1000);
// Console.WriteLine(number);

// int N1 = number % 10;
// int N2 = number / 100;
// // Console.WriteLine(N1);
// // Console.WriteLine(N2);

// int itog = N2 * 10 + N1;
// Console.WriteLine(itog);




//Задача 12

// Console.WriteLine("Введите первое число:");
// int N1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число:");
// int N2 = Convert.ToInt32(Console.ReadLine());

// int ost = N1 % N2;
// if(ost == 0){
//     Console.WriteLine("Кратны");
// }else{
//     Console.WriteLine($"Остаток равен: {ost}");
// }




//Задача 14
// Console.WriteLine("Введите число:");
// int N1 = Convert.ToInt32(Console.ReadLine());

// bool CheckKrat(int number)
// {

//     if(number % 7 == 0 && number % 23 == 0){
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// bool result = CheckKrat(N1);
// if(result == true)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine("Не кратно");
// }



//Задача 16

//Вариант 1
// Console.WriteLine("Введите первое число:");
// int N1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число:");
// int N2 = Convert.ToInt32(Console.ReadLine());

// if(N1 > N2){
//     if(N2 * N2 == N1){
//         Console.WriteLine("Да");
//     }else{
//         Console.WriteLine("Нет");
//     }
// }else{
//     if(N1 * N1 == N2){
//         Console.WriteLine("Да");
//     }else{
//         Console.WriteLine("Нет");
//     }
// }



//Вариант 2

Console.WriteLine("Введите первое число:");
int N1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int N2 = Convert.ToInt32(Console.ReadLine());


bool CheckSqrt(int namber1, int namber2)
{
if(namber1 > namber2){
    if(namber2 * namber2 == namber1){
        return true;
    }else{
        return false;
    }
}
else
{
    if(namber1 * namber1 == namber2){
        return true;
    }else{
        return false;
    }
}
}

bool result = CheckSqrt(N1, N2);
if(result == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}






//Методы

//Random random = new Random();
// Для генерации рандомных чисел
// int randomNumber = random.Next(10, 100);

// Console.WriteLine(randomNumber);

// int GetMaxNumber(int number)
// {
//     int lastNumber = number % 10;
//     int firstNumber = number / 10;

//     if (lastNumber > firstNumber)
//     {
//         return lastNumber;
//     }
//     else
//     {
//         return firstNumber;
//     }
// }


// int result = GetMaxNumber(randomNumber);

// Console.WriteLine($"Максимальное число равно {result}");// интерполяция
