//задайте двумерный массив  mxn , заполненный случайными цифрами, 
// m=3 n=4
/*

int[,] Array2D()
{
    Console.Write("input count of rows:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input count of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input min:");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("input max:");
    int max = Convert.ToInt32(Console.ReadLine());
    
    int[,]array = new int [rows,columns]; // row строка // colmus столбец
    for(int i=0; i < rows; i++)
        for(int j=0; j < columns; j++)
            array[i,j] = new Random().Next(min,max);
    return array;
    
}

void Show2D(int[,]array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
    

//int[,]newArray = Array2D();
//Show2D(newArray); 
/*


//Задайте двумерный массив размером m на n каждый элемент в массиве находится по формуле Amn = m+n
//выведите полученный массив на экране 
//

/*
int[,] Mas(int rows, int colmus)
{
    int[,]array = new int [rows, colmus];
    for(int i=0; i<rows; i++)
        for(int j = 0; j<colmus; j++)
            array[i,j] = i+j;
    return array;
}

Show2D(Mas(3,4));
*/

//задайте двумерный массив, найдите элементы, у которых оба индекса четные
//и замените эти элементы на их квадраты

/*

int[,] ReArray ( int [,] array2 )
{
    for(int i=0; i < array2.GetLength(0); i++)
    {
        for(int j=0; j < array2.GetLength(1);j++)
        {
            if(i%2 != 1 && j%2 != 1)
            {
                array2[i,j] *= array2[i,j] ;
            }
        }
    }
    return array2;
}


int[,] array1 = Array2D();
Show2D(array1);
Console.WriteLine();
int[,]array2 = ReArray(array1);
Show2D(array2);
/*
while(user_input != t)
    if(user_input >0 ) count +=1;  к домашке 6
*/

///____________________Лекция____________________________
// Главное условие рекурсии - выход
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.Write(SumRec(10));
