//Задача 2:Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7, min = 5
//a = 2 b = 10 -> max = 10, min = 2


/*
Console.WriteLine("Input a number A: ");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number B: ");
int num_B = Convert.ToInt32(Console.ReadLine());

if(num_A > num_B)
{
    Console.WriteLine($"max = {num_A}, min ={num_B}");
}
if(num_B > num_A)
{
    Console.WriteLine($"max = {num_B}, min ={num_A}");
}
else
{
    Console.WriteLine($"the numbers are equal");
}


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Input num_1: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input num_2: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input num_3: ");
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (num_1 < num_2) max=num_2;
if (num_2 < num_3) max=num_3;
Console.WriteLine($"Max number: {max}");


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2 == 0) Console.WriteLine($"{number} is even");
else Console.WriteLine($"{number} is not even");
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8


Console.WriteLine("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());
int num = 1;
Console.Write("Even numbers: ");
while(num <= N)
{
    if(num % 2 == 0)
    Console.Write(num +" ");
    num++;
}