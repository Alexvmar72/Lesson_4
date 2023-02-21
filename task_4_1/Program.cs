/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16           */

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int MajorProced(int num, int expon)
{
    int tmp = 1;
    for (int i = 0; i < expon; i++)
    {
        tmp = num * tmp;
    }
    return tmp;
}

int num = Prompt("Введите число: ");
int expon = Prompt("Введите степень числа: ");

Console.WriteLine($"Число {num} в степени {expon} равно {MajorProced(num, expon)}");


