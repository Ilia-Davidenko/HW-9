// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(Ackker(firstNum, secondNum));

int Ackker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackker(m - 1, 1);
    }
    else
    {
        return Ackker(m - 1, Ackker(m, n - 1));
    }
}