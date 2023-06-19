﻿// Задача 64: Задайте значение N.
//  Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// int m = Prompt("Введите m");
int n = Prompt("Введите число N");
Console.WriteLine(PrintNumbers(n));
string PrintNumbers(int start)
{
    if (start == 1)
    {
        return start.ToString();
    }
    return start + "," + PrintNumbers(start - 1);
}