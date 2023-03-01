//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

     /*_______________


double[,] ArrayDigit(int rows, int colmus, int min, int max ) 
{
    double[,] array = new double [rows, colmus];
    for(int i=0; i < rows; i++)
    {
        for(int j=0; j < colmus;j++)
        {
            array[i,j] = Math.Round((new Random().Next(min,max)) + (new Random().NextDouble()), 1);
        }
    }
    return array;
}

void ShowArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();    
    }
    
}

double[,] array = ArrayDigit(3,4, -10,10);
ShowArray(array);


   ___________________ */






/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

     /*__________________________

int[,] Array2D(int row, int colmn, int min, int max)
{
    int[,]newarray = new int[row,colmn];
     for(int i=0; i<row;i++)
     {
       for(int j=0; j<colmn; j++)
        newarray[i,j] = new Random().Next(min, max);  
     }
    return newarray;
}


void ShowArray2D(int [,] array)
{
  for(int i=0; i<array.GetLength(0); i++)
  {
    for(int j=0; j<array.GetLength(1);j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

     _____________________*/



    /*______________________


int Result (int[,] array, int digit)
{
    int result =0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            if(array[i,j] == digit) result =1; 
    }
    return result;
  
}
    _________________________*/



    /*________________________

Console.WriteLine("Input row:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input colmn:");
int colmn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input digit:");
int digit = Convert.ToInt32(Console.ReadLine()); 
int[,] array = Array2D(row,colmn,min,max);
int result = Result(array,digit);
ShowArray2D(array);
if(result == 1) Console.WriteLine($"the {digit} is present Array");
else Console.WriteLine($"the {digit} is missing Array");

    ___________________________*/



//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Код работает не со всеми значениями, вернусь к этой задаче, буду дорабатывать, когда время позволит
// С этими значениямит код будет работать 

    /*______________________
void Average(int[,] array)
{   int digit=array.GetLength(1);
    for (int j = 0; j < array.GetLength(1); j++)
        {
            double sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
               // sum = Math.Round((sum +array[i,j]) / digit ,1);
               sum = sum + array[i,j];
            }
            Console.WriteLine("Sum in {0} column: {1}", j, sum );
            Console.WriteLine("Average in {0} column: {1}", j, Math.Round((sum/digit),1 ));
            
        }
}


int[,] array2D = Array2D(4,4,1,10);
ShowArray2D(array2D);
Average(array2D);
    _______________________*/