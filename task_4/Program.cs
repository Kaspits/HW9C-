/* Задача 69: Напишите программу,
которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

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

int Value(int A, int B)
{
    if (B == 1)
    {
        return A;
    }
    else
    {
        return Value(A, B - 1) * A;
    }
}
Console.WriteLine(Value(GetNumber("Enter number A"), GetNumber("B")));
