// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа по убыванию в промежутке от M до N.

int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
System.Console.WriteLine();
GetNumbers(firstNum, secondNum);
//Console.WriteLine(GetNumbers);

void GetNumbers(int m, int n)
{
    if (n > m + 1)
    {
        Console.WriteLine($"{n - 1}");
        GetNumbers(m, n - 1);
    }
}
