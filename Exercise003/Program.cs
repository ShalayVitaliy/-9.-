// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}


int[] InitialValues(string msg)
{
    Console.Write(msg);
    int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    return array;
}

Console.Clear();
int[] numbers = InitialValues("Enter numbers: ");
Console.WriteLine($"Accerman function for A({numbers[0]},{numbers[1]}) = {AckermannFunction(numbers[0], numbers[1])}");