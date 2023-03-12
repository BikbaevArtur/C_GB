/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


/*

int[,] Array2D()
{
    Console.WriteLine("Input row array: ");
    int rowAr = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input column array: ");
    int colmnAr = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input minVol array: ");
    int minVol = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input maxVol array: ");
    int maxVol = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rowAr, colmnAr];
    for (int i = 0; i < rowAr; i++)
    {
        for (int j = 0; j < colmnAr; j++)
        {
            array[i, j] = new Random().Next(minVol, maxVol + 1);
        }
    }
    return array;
}

*/

void Show2Darray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

/*

int[,] SortArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }

    return array;
}

int[,] newarray = Array2D();
Show2Darray(newarray);
Console.WriteLine();
int[,] sortArray = SortArray2D(newarray);
Show2Darray(sortArray);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

/*

int[] SumRow(int[,] array)
{
    int size = array.GetLength(0);
    int[] arraysum = new int[size];
    for (int k = 0; k < arraysum.Length; k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
                sum += array[i, j];
            arraysum[i] = sum;
        }
    }
    return arraysum;


}




void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

*/


/*

void Result(int[] array)
{
    int indexmin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[indexmin]) indexmin = i;

    }
    Console.WriteLine($"the row with the smallest sum of elements: {indexmin}");
}

*/



/*

int[,] newarray = Array2D();
Show2Darray(newarray);
int[] sum = SumRow(newarray);
Console.WriteLine();
ShowArray(sum);
Console.WriteLine();
Result(sum);
*/


/*
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 9, 9, 0,
2, 8, 0, 9
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
*/


int[,] Array2D(int row, int column, int min, int max)
{


    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}


void Frequency(int[,] array, int digit1, int digit2)
{
    while (digit1 < digit2)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                if (digit1 == array[i, j]) count++;
        }
        if (count > 0) Console.WriteLine($"{digit1} встречается {count}");
        digit1++;

    }
}

Console.WriteLine("Input row array: ");
int rowAr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input column array: ");
int columnAr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minVol array: ");
int minV = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maxVol array: ");
int maxV = Convert.ToInt32(Console.ReadLine());

int[,] array2D = Array2D(rowAr, columnAr, minV, maxV);
Show2Darray(array2D);
Console.WriteLine();
Frequency(array2D, minV, maxV);

/*

Задача 58:(дополнительная) Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/


/*
Задача 60.(дополнительная) ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/*
Задача 62ю (дополнительная). Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/