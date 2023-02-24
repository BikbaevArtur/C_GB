//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3
int Prompt (string mas)
{
    System.Console.Write(mas);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int [] Inp(int lenght)
{
    int [] arr = new int [lenght];
    for (int i=0; i < arr.Length; i++)
    {
        arr[i]=Prompt($"введите {i+1}");

    }
    return arr;
}   

void Pri(int[] arr)
{
    for(int i=0; i < arr.Length; i++)
    Console.WriteLine($"a{i} = {arr[i]}");
}

int Count ( int[] array)
{
    int count =0;
    for(int i=0; i<array.Length; i++)
        if(array[i] > 0)
            count++;
    return count;
} 

int lenght = Prompt("Введите");
int [] array;
array = Inp(lenght);
Pri(array);
Console.WriteLine($"Кол во{Count(array)}");













//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)