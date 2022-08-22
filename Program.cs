//Задача 2
Console.WriteLine("Введите первое число:");
int N1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int N2 = Convert.ToInt32(Console.ReadLine());

if(N1 == N2){
    Console.WriteLine("Числа равны.");
}else{
    if (N1 > N2){
        Console.WriteLine("Первое число больше");
    }else{
        Console.WriteLine("Второе число больше");
    }
}

//Задача 4
Console.WriteLine("Введите первое число:");
N1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
N2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int N3 = Convert.ToInt32(Console.ReadLine());

if(N1 == N2 && N2 == N3){
    Console.WriteLine("Числа равны.");
}else{
    if (N1 > N2){
        if(N1 > N3){
            Console.WriteLine("Первое число больше");
        }else{
            Console.WriteLine("Третье число больше");
        }
    }else{
        if(N2 > N3){
            Console.WriteLine("Второе число больше");
        }else{
            Console.WriteLine("Третье число больше");
        }
    }
}


//Задача 6
Console.WriteLine("Введите число:");
N1 = Convert.ToInt32(Console.ReadLine());

if(N1 % 2 == 0){
    Console.WriteLine("Четное");
}else{
    Console.WriteLine("Не четное");
}


//Задача 8
Console.WriteLine("Введите число N:");
N1 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N1; i++){
    Console.Write(i);
    Console.Write(" ");
}