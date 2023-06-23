// Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

using System;
using static System.Console;

Clear();
WriteLine("Введите число N: ");
int n = int.Parse(ReadLine());

WriteLine(NaturalNumber(n, 1));

int NaturalNumber(int a, int b)
{
    if(a == b) return a;
    else Write($"{NaturalNumber(a, b + 1)}, ");
    return b;
}