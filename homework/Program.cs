// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int m = 1;

void Rec(int n, int m)
{
    if (m > n)
    {
        return;
    }
    else
    {
        Rec(n, m + 1);
        Console.Write(m + " ");
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Rec(n, m);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int Sum(int m, int n)
// {
//     int summa = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         summa = m + Sum(m, n);
//         return summa;
//     }
// }
// Console.Clear();
// Console.Write("Введите число: "); 
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: "); 
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write(Sum(m - 1, n));
