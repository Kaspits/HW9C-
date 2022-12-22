/* Задача 63: Задайте значение N.
Напишите программу, которая выведет все натуральные числа
в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

int GetNumber(string messege)
{
    Console.WriteLine(messege);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result > 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не то, что нужно");
        }
    }
    return result;
}

string GetValues(int n)
{
    if (n == 1)
    {
        return n.ToString();
    }
    return GetValues(n - 1) + $", {n}";
}

int n = GetNumber("Enter number bigger 1");
GetValues(n);
Console.WriteLine(GetValues(n));
