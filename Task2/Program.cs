/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Введите значение M ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите значение N ");
int n = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine($"Сумма всех элементов от {m} до {n} равна {GetSum(m, n)}");

int GetSum(int min, int max)
{
    if (min == max) return max;
    return (min + (GetSum(min + 1, max)));
}
