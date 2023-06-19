﻿// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Prompt("Введите m");
int n = Prompt("Введите n");
Console.WriteLine(PrintNumbers(m, n));

int PrintNumbers(int start, int finish)
{
    int sum = m;
    for (int i = m; i <= n; i++)
    {
        sum +=i;
    }
    return sum - m;
    // int sum = m;
    // if (start == finish)
    //     return 0;
    // else
    // {
    //     m++;
    //     sum = m + PrintNumbers(m,n);
    //     return sum;
    // }
}