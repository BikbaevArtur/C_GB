//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*

void NumDegree (int num, int deg)
{
    int i = 0;
    int result = 1;
    while(i < deg)
    {
        result = result * num;
        i++;
    }
    Console.WriteLine($"Degree {deg} of number{num} = {result}");

}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input degree: ");
int degree = Convert.ToInt32(Console.ReadLine());

NumDegree(number,degree);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

/*
int Summ(int num)
{
    int sum = 0;
    int num1 = num;
    while(num1 > 0)
    {
        sum = num1%10 + sum;
        num1 = num1/10;
    }
    return sum;
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Summ(number);
Console.WriteLine($"Summ digits {number} = {result}"); // можно было на минусовые сделать, но времени не хватает =(

*/

// Задача 29: Напишите программу, которая задаёт массив из произвольного кол.во элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int [] CreatArray (int size )
{
    int [] random = new int [size]; 
    for(int i = 0; i < size; i++)
    {
    random[i] = new Random().Next(0, 100);// 
    }
    return random;   

}

void ShowCratArray (int [] array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] +" ");
    }
}
Console.WriteLine("Input size array: ");
int sizearray = Convert.ToInt32(Console.ReadLine());
int [] arrayNew = CreatArray(sizearray);
ShowCratArray(arrayNew);


