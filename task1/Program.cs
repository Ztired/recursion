// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

int M = 15;
int N = 85;

void ShowNaturalNumbers(int min, int max)
{
    if (min == max+1) return;
    Console.Write(min + " ");
    ShowNaturalNumbers(min + 1,N);
}
ShowNaturalNumbers(M,N);