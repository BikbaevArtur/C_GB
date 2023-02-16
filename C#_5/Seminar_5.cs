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
void DigitsAr (int[] array, int digits)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == digits) Console.WriteLine("+") ;
        else Console.WriteLine("-");
    }

    
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
DigitsAr(array1, digitsarray);
