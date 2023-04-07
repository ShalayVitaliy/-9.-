// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string OutPutNumber(int num)
{
    if(num == 1)
        return 1.ToString();
    return  num.ToString() + ", " + OutPutNumber(num - 1);
}

int Prompt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

Console.Clear();
int Number = Prompt("Enter a number: ");
Console.Write(OutPutNumber(Number));