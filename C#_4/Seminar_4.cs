//Задача 1
//Напишите программу, которая принимает на вход число (A) и выдает сумму числе от 1 до A
/*
Мое решение задачи
int Summ(int number)
{
    int sum = 0;
   for(int n = 1; n <= number; n++)
   {
    sum = sum + n; // summ += n тоже самое как и до этого 
   }
   return sum;
   
   
}
int num = Convert.ToInt32(Console.ReadLine());
if( num > 0) int result = Summ(num);
else Console.WriteLine("-");
Console.Write(result);
*/

// Задача 2
// Напишите программу, которая принимает на вход число, и выдает количестно цифр в числе

void ColNum (int num)
{   int count = 0;
    while(num > 0)
    {
        num = num/10;
        count ++;
    }
    Console.WriteLine($"number of digits: {count}");
}
Console.WriteLine("input number");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0) n=n * 1;
else n = n * -1;
ColNum(n);
