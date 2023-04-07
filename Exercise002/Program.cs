// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.



int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
    else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
    else if (M == N) return M;                       // Если M=N
    else if (M < N) return N + SumNumbers(M, N - 1); // Если M<N
    else return N + SumNumbers(M, N + 1);            // Если M>N
}


int[] InitialValues(string msg)
{
    Console.Write(msg);
    int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    return array;
}
Console.Clear();
int[] numbers = InitialValues("Enter numbers: ");
Console.Write(SumNumbers(numbers[0], numbers[1]));