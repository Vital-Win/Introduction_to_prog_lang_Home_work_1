// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число:");
string? numberString = Console.ReadLine()!;
int number = int.Parse(numberString);

if (number <= 1)
{
     Console.WriteLine("Введите число больше 1");
}

int i = 2;

while (i <= number)
    {
        Console.WriteLine(i);
        i = i + 2;
    }