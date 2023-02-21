/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]                          */

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int len_result = int.Parse(Console.ReadLine()!);
    return len_result;
}

int[] GetBinaryArray(int len)
{
    int[] result = new int[len];
    for (int j = 0; j < len; j++)
    {
        result[j] = new Random().Next(101);
    }
    return result;
}

int len = Prompt("Введите размер массива: ");
int[] table = GetBinaryArray(len);
Console.WriteLine($"{len} -> [{string.Join(", ", table)}]");