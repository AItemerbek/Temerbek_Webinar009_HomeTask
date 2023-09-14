// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}

void PrintNums(int number)
{
    Console.Write(number + " ");
    if (number > 1)
        PrintNums(number - 1);
    if (number < 1)
        PrintNums(number + 1);
}

Console.Clear();
int num = InputNum("Введите число N и программа распечатает все числа в промежутке от N до 1: ");
PrintNums(num);