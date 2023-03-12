// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int EnterNumber(string text)
{
    Console.WriteLine(text);
     return Convert.ToInt32(Console.ReadLine());
}
int SumNumbers(int m, int n)
{
    if (m == n) return m;
    return m + SumNumbers(m +  1, n);
}


int m = EnterNumber("Введите число M: ");
int n = EnterNumber("Введите число N: ");
Console.WriteLine(SumNumbers(m,n));