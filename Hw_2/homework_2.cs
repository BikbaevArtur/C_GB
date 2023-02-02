//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
Console.WriteLine("Input 3_diget number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>99 && number < 1000)
{
    int r = (number%10);
    int result = (number % 100 - r)/10;
    Console.WriteLine(result);
}
else
    Console.WriteLine($"{us_number} is not 3_digit number");


int SecNum(int number)
{
    int r = (number%10);
    int m = (number % 100 - r)/10;
    return m;
}

Console.WriteLine("Input 3_digit number: ");
int us_number = Convert.ToInt32(Console.ReadLine());
if(us_number>99 && us_number < 1000)
{
    int result = SecNum(us_number);
    Console.WriteLine($"secont number: {result}");
}
else
    Console.WriteLine($"{us_number} is not 3_digit number");


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Input number");
int  number = Convert.ToInt32(Console.ReadLine());
if(number > 100)
    while(number > 1000)
{
    number = number /10;
}
else
    Console.WriteLine("number is not 3 digit");
int digit_3 = number % 10;
Console.WriteLine($"thrid number {digit_3}");
*/



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("enter the day on the week:");
int day = Convert.ToInt32(Console.ReadLine());
if(day < 8)
    if(day==6 || day == 7)
    Console.WriteLine($"day {day} - weekend");
    else Console.WriteLine($"day {day} - working day");
else Console.WriteLine("Error");

