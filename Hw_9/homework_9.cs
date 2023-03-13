//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void Subsequence(int number)
{
    Console.Write(number + " ");
    if (number > 1) Subsequence(number - 1);
    
}
Console.WriteLine("Input number:");
int num = Convert.ToInt32(Console.ReadLine());
Subsequence(num);

*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
int SummDigit( int num1,int num2)
{
    if (num2 == num1) return num1;
    else return num2+SummDigit(num1,num2-1);
}

Console.WriteLine("Input start digit:");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input end digit:");
int endNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of natural elements between {startNumber} & {endNumber} equals {SummDigit(startNumber,endNumber)}");
*/


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int Akker(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akker(m - 1, 1);
    if (m > 0 && n > 0) return Akker(m - 1, Akker(m, n - 1));
    return Akker(m, n);
}

Console.WriteLine(Akker(2, 3));
