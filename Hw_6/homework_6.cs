//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3


int[] Mass (int size)
{
    int [] newArray = new int [size];
    Console.Write("Input num: ");
    for (int i=0; i<size; i++)
        newArray[i]=Convert.ToInt32(Console.ReadLine());
    return newArray;
}

void ShowArray ( int[]array)
{
    for(int i=0;i<array.Length;i++)
        Console.Write(array[i] + " ");
}

int Result (int [] resultArray)
{
    int count = 0;
    for(int i=0; i<resultArray.Length; i++)
        if(resultArray[i]>0)count++;
    return count;
}


Console.WriteLine("How many numbers do you want to check");
int sizearray = Convert.ToInt32(Console.ReadLine());

int []  numArray = Mass(sizearray);
ShowArray(numArray);
Console.WriteLine($"The numbers of digits > 0 = {Result(numArray)}");









//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)