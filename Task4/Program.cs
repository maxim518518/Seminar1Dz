 
// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.



// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


System.Console.Write("Введите первое число 'A': ");
int A = Convert.ToInt32 (Console.ReadLine());

System.Console.Write("Введите второе число 'B': ");
int B = Convert.ToInt32 (Console.ReadLine());

System.Console.Write("Введите второе число 'C': ");
int C = Convert.ToInt32 (Console.ReadLine());

int max = A;

if (B > max) 
{
    max = B;
}


if (C > max)
{
    max = C;
}

System.Console.WriteLine("Максимальное число: " + max );