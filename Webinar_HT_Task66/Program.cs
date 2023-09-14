// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}

int SumNums(int numberM, int numberN)
{
    int result = 0;
    result += numberN;
    if (numberM < numberN)
        result += SumNums(numberM, numberN - 1);
    return result;
}

// поределим какое число из двух больше

bool NumsTest(int num1, int num2)
{
    return num1 < num2;
}

Console.Clear();
int firtsNum = InputNum("Input first number: ");
int secondNum = InputNum("Input second number: ");
if (NumsTest(firtsNum, secondNum))
    Console.WriteLine(SumNums(firtsNum, secondNum));
else
    Console.WriteLine(SumNums(secondNum, firtsNum));
