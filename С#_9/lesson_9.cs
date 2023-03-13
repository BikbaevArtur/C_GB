//задача 1 
//Задайте значение N. Напишите программу, которая выведет все натуральные
//числа в промежутке от 1 до N

/*
void Resurs(int n)
{
    if (n > 1) Resurs(n - 1);
    Console.Write(n + " ");   //если поменять местами, будет вывод от n До 1 
}

Resurs(10);
*/

//Задача 2 
// напишите программу которая будет принимать на воход 
//число и возвращать сумму его цифр
/*
int SumDigit(int num)
{
    if (num < 0) num = num * (-1);
    if (num > 0) return SumDigit(num / 10) + num % 10;
    else return 0;
}

Console.WriteLine(SumDigit(24));
*/



//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// N < M, N = M, M < N
/*
void ShowNumb(int n, int m)
{
    if (Math.Min(n, m) != Math.Max(n, m)) ShowNumb(Math.Min(n, m) + 1, Math.Max(n, m));
    Console.Write($"{Math.Min(n, m)} ");
}

ShowNumb(1,-15);
*/

//Напишите программу которая на вход принимает два числа A and B
//и возводит число A в целую степень B с помощью рекурсии

// Возведение в степень

double FindPower(int a, int b)
{
    if (b > 0) return FindPower(a, b - 1) * a;
    if (b < 0) return FindPower(a, b + 1) / a;
    else return 1.0;
}

Console.WriteLine(FindPower(2, -5));