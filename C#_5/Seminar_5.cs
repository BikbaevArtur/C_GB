// Задаййте массив из 12 элементов, заполните случайными числами из промежутка [-9. 9]
// Найдите сумму отрицательных элементов массива
/*
int [] NewArray (int size, int minValue, int maxValue)
{
    int[] random = new int[size];
    for(int i = 0; i < size; i++)
    {
        random[i] = new Random().Next(minValue, maxValue +1);
    } 
    return random;

}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindSumNeg(int[] array)
{
    int sum = 0;
    for(int i = 0 ; i < array.Length; i++)
    {
        if(array[i]<0) sum += array[i]; // sum = sum+array[i]
    }
    return sum;
}

int[] array01 = NewArray(12, -9, 9);
ShowArray(array01);
int result = FindSumNeg(array01);
Console.WriteLine(result);
*/

// Напишите программ, замены элементов массива : положительные элементы заменить на соответсвтующие
// отрицательные, и наобарот

/*
int [] ArrayNew ( int size, int minV, int maxV)
{
    int [] random = new int[size];
    for(int i=0; i<size; i++)
    {
        random[i] = new Random().Next(minV, maxV +1);
    }
    return random;
}

void ShowAr ( int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/
/*int [] RewArray ( int[] array)
{
    for(int i=0; i<array.Length;i++)
    {
        array[i] *= -1;
    }
    return array;
}
*/
//int[] array1 = ArrayNew(8, -10, 10); // массив
//ShowAr(array1);// показать массив
//RewArray(array1);//замена знач
//ShowAr(array1);// показ замененный

// Задача
// Задайте массив. Напишите программу которая определяет, присутствует ли 
// заданное число в массиве
/*
bool DigitsAr (int[] array, int digits) // логическое bool или правда или лож
{   

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == digits) return true;
    }
    return false;

    
}



Console.WriteLine("Input size array: ");
int sizearray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min number array: ");
int minarray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max numb array: ");
int maxarray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input digits: ");
int digitsarray = Convert.ToInt32(Console.ReadLine());

int[] array1 = ArrayNew(sizearray, minarray, maxarray);
ShowAr(array1);
bool result = DigitsAr(array1, digitsarray);
if(result == true) Console.WriteLine("+");
else Console.WriteLine("-");
*/
//Задача
//Нужно найти произведение пар чисел в одномерном массиве. Парой считается первый и последий элемент.
//Второй и предпоследний и тд. Результат запишите в новом массиве

int [] ArrayNew ( int size, int minV, int maxV)
{
    int [] random = new int[size];
    for(int i=0; i<size; i++)
    {
        random[i] = new Random().Next(minV, maxV +1);
    }
    return random;
}

void ShowAr ( int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int NewArraySize ( int start_size)
{
    int end_size = 0;
    if(start_size%2 ==0)
        end_size = start_size/2;
    else
        end_size = start_size/2 +1 ;
    return end_size;

}

int[] ArrayProduct(int [] massiv)
{
    int result_size = NewArraySize(massiv.Length);
    int[] result_array= new int[result_size];
    for(int i=0; i <  massiv.Length /2 +1 ; i++)
    {
        if(i==massiv.Length -1 -i)
            result_array[i]= massiv[i];
        else
            result_array[i] = massiv[i] * massiv[massiv.Length -1 -i];
        
    }
    return result_array;
  
}   





Console.WriteLine("Input size array: ");
int sizearray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min number array: ");
int minarray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max numb array: ");
int maxarray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input digits: ");

int[] first_array = ArrayNew(sizearray,minarray,maxarray);
ShowAr(first_array);
int[] secondArray = ArrayProduct(first_array);
ShowAr(secondArray);