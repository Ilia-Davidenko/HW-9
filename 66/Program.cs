// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(GetSum(firstNum, secondNum));

int GetSum(int m, int n)
{
    if (m <= n) return (m + GetSum(m + 1, n));
    return 0;
}