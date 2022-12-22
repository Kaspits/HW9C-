/* Задача 64: Задайте значение N.
Напишите программу, которая выведет все натуральные числа
в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

// int GetNumber(string messege)
// {
//     Console.WriteLine(messege);
//     int result = 0;
//     while (true)
//     {
//         if (int.TryParse(Console.ReadLine(), out result) && result > 1)
//         {
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Ввели не то, что нужно");
//         }
//     }
//     return result;
// }

// void GetValues(int n)
// {
//     Console.Write($"{n}, ");
//     if (n > 1)
//     {
//         GetValues(n - 1);
//     }
// }

// int n = GetNumber("Enter number bigger 1");
// GetValues(n);
//...........................................................................................

/* Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
// int m = GetNumber("Enter number m");
// int n = GetNumber("Enter number n");

// // Значение M и N.
// int GetNumber(string messege)
// {
//     Console.WriteLine(messege);
//     int result = 0;
//     while (true)
//     {
//         if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
//         {
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Ввели не то, что нужно");
//         }
//     }
//     return result;
// }

// SumFromMToN(m, n);

// // вызов функции "сумма чисел от M до N"
// void SumFromMToN(int m, int n)
// {
//     Console.Write(SumMN(m - 1, n));
// }

// // функция сумма чисел от M до N
// int SumMN(int m, int n)
// {
//     int result = 0;
//     if (m == n)
//     {
//         return 0;
//     }
//     else
//     {
//         m++;
//         result = m + SumMN(m, n);
//         return result;
//     }
// }

/* Задача 68: Напишите программу вычисления
функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int m = GetNumber("Enter number m");
int n = GetNumber("Enter number n");

AkkermanFunction(m, n);

// Значение M и N.
int GetNumber(string messege)
{
    Console.WriteLine(messege);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
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

// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n));
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
