
//задайте двумерный массив. Напишите программу, которая поменяет местами любые две строки массива.
/*
int [,] Creat2DArray(int row, int column, int minV, int maxV)
{
    int[,] array = new int [row,column];
    for(int i=0; i<row; i++)
    {
        for(int j=0; j<column; j++)
            array[i,j]= new Random().Next(minV, maxV+1);
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
int[,] ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >=0 && row1 < array.GetLength(0) && row2>=0 && row2 < array.GetLength (1))
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1,j];
            array[row1,j] = array[row2,j];
            array[row2,j]= temp;
        }
    }
    else Console.WriteLine("incorrect input");
    return array;

}

Console.WriteLine("Input row array: ");
int rowAr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input column array: ");
int colmnAr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minVol array: ");
int minVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maxVol array: ");
int maxVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"input number of the first row to remove from 0 to {rowAr-1}");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input row2 array: ");
int row2 = Convert.ToInt32(Console.ReadLine());


int[,] array2D = Creat2DArray (rowAr, colmnAr, minVol, maxVol);
Show2Darray(array2D);
int[,] arraychenge = ChangeRows(array2D, row1, row2);
Console.WriteLine();
Show2Darray(arraychenge);
*/

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы
// В случае, если это невозможно, программа должна вывести сообщение для пользователей 

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

/*
int[,] CreatArray(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Let it be squar matrix& 4x4 for example ");
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }
    return array;
}

int[,] array1 = Array2D();
Show2Darray(array1);
Console.WriteLine();
int[,] array2 = CreatArray(array1);
Show2Darray(array2);


*/

//Задайте двумерный массив из целых чисел.напишите программу , которая обнулит строку и столбец,
//на пересечении  которых расположен первый наименьишй элемент массива

int[] MinDigit(int[,] array)
{
    int[] indexmin = new int[2];
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }


        }
    }
    indexmin[0] = iMin;
    indexmin[1] = jMin;
    return indexmin;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}


int [,] CreatArray ( int [,] creatArray, int [] arrayMin)
{
    for(int i=0; i<creatArray.GetLength(0); i++)
    {
        creatArray[i, arrayMin[1]]=0;
    }
    for(int j=0; j<creatArray.GetLength(1); j++)
    {
        creatArray[arrayMin[0], j] =0;
    }
    
    return creatArray;
}














int[,] newarray2D = Array2D();
Show2Darray(newarray2D);
Console.WriteLine();
int[] min = MinDigit(newarray2D);
ShowArray(min);
Console.WriteLine();
int[,] creatarray = CreatArray(newarray2D, min);
Show2Darray(creatarray);
