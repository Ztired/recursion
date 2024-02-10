// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


int[] RandomDigitInArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max +1);

    }
    return array;
}

void PrintArray(int[] arr, int size)
{
    if (size == 0)
    {
        Console.Write(arr[size]);
        return;
    }
    Console.Write(arr[size] + " ");
    PrintArray (arr, size - 1);
}

Console.Write("Введите размер массива  ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = RandomDigitInArray(n, 0, 100);
Console.Write($"Массив: {string.Join(" ", array)}");
Console.WriteLine();
PrintArray(array, array.Length - 1);
Console.WriteLine();

