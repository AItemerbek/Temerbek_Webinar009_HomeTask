// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int InputNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}

int AckermannFunction(int numberN, int numberM)
{
    if (numberN == 0)
        return numberM + 1;
    else if (numberM == 0)
        return AckermannFunction(numberN - 1, 1);
    return AckermannFunction(numberN - 1, AckermannFunction(numberN, numberM - 1));
}

Console.Clear();
int firtsNum = InputNum("Input first number: ");
int secondNum = InputNum("Input second number: ");

Console.WriteLine(AckermannFunction(firtsNum,secondNum));
