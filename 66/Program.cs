// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using System;
using static System.Console;

Clear();
WriteLine("Введите число N: ");
int n = int.Parse(ReadLine());
WriteLine("Введите число M: ");
int m = int.Parse(ReadLine());

WriteLine(Summa(n,m));

int Summa(int a, int b)
{
    if (a == b) return a;
    else return Summa(a + 1, b) + a;
}

