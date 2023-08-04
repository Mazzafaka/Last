// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void Main()
{
    Console.Write("Введите значение m: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите значение n: ");
    int n = int.Parse(Console.ReadLine());

    int result = AckermannFunction(m, n);
    Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n}: {result}");
}

int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
        else
        {
            throw new ArgumentException("Значения m и n должны быть неотрицательными.");
        }
    }

Main();