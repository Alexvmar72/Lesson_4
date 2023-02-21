/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12                */

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

int GetSum(int n)
{
    int sum = 0;

    while (n >= 1)
    {
        int tmp = n % 10;
        n = n / 10;
        sum += tmp;
    }
    return sum;
}

Console.WriteLine($"Сумма цифр в числе {n} равна {GetSum(n)}");