// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Пожалуйста введите три целых числа через пробел и нажмите Enter:");
string?[] number = Console.ReadLine().Split(' ')!;
int number1 = int.Parse(number[0]);
int number2 = int.Parse(number[1]);
int number3 = int.Parse(number[2]);

int max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.WriteLine(max);