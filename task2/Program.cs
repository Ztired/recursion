﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetAkkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0)
{
  return GetAkkerman(m - 1, 1);  
} 
else 
{
    return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
}
}
Console.Write($"Функция Аккермана равна {GetAkkerman(m, n)} ");