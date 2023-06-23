﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;
using static System.Console;

Clear();
WriteLine("Введите число N: ");
int n = int.Parse(ReadLine());
WriteLine("Введите число M: ");
int m = int.Parse(ReadLine());

Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}
