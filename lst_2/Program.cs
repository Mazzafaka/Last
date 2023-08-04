// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Main()
{
    Console.Write("Введите значение N: ");
    int N = int.Parse(Console.ReadLine());
    Console.Write("Введите значение M: ");
    int M = int.Parse(Console.ReadLine());
    int numbers = PrintNumbers(N, M);

    Console.WriteLine($"Сумма натуральных чисел M и N: {numbers}");
}

int PrintNumbers(int first, int last)
{
    if (first > last)
        {
            return 0;
        }
        return first + PrintNumbers(first + 1, last);
}

Main();
