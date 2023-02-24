//Напишите программу который перевернет одномерный массив
//
/*


int [] NewArray(int size, int minDig, int maxDig)
{
    int[] newArray = new int [size];
    for(int i=0; i<size; i++) newArray[i] = new Random().Next(minDig, maxDig+1);
    return newArray;
}

void ShowArray ( int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}

int [] SortArray(int[] array)
{
    int i=0;
    
    
    while(i<array.Length/2 )
    {
        int temp=array[array.Length -1 -i];
        array[array.Length -1 -i] = array[i];
        array[i]= temp;
        i++;
    }
    return array;
}

int newsize = Convert.ToInt32(Console.ReadLine());
int minDig = Convert.ToInt32(Console.ReadLine());
int maxDig = Convert.ToInt32(Console.ReadLine());

int[] array = NewArray(newsize, minDig, maxDig);
ShowArray(array);
Console.WriteLine();
int[] sortarray = SortArray (array);
ShowArray(sortarray);
*/

// напишите программу которая будет преобразовывать десфтичные числа, в двоичные
/*
string BinarSystem(int num)
{
    string result = string.Empty;
    while ( num != 0)
    {
        result = num%2 + result;
        num = num/2;
    }
    return result;
}

Console.WriteLine("input num");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Binar = {BinarSystem(num)}");
*/

//введите первые N чисел фибоначи. Превые два числа фибаначи 
/*

int[] FIb (int size, int array0 , int array1)
{
    int[] fibArray = new int [size];
    fibArray[0]= array0;
    fibArray[1]= array1;
    for(int i = 2; i < size ; i++)
    {
        
        fibArray[i] = fibArray[i-1] + fibArray[i-2];  
    }
    return fibArray;
}

void ShowArray (int[] array)
{
    for(int i=0; i < array.Length; i++)
    Console.Write(array[i]+ " ");
}

int size = Convert.ToInt32(Console.ReadLine());
int array0 = Convert.ToInt32(Console.ReadLine());
int array1 = Convert.ToInt32(Console.ReadLine());
int [] fib = FIb(size, array0, array1);
ShowArray (fib);
*/


// Напишите программу , которая проверяет на вход три числа, и проверяет
//может ли существовать треугольник со сторонами  такой длинны
// каждая сторона треугольника, меньше суммы двух сторон 
void Triangle ( int a, int b , int c)
{
    if(a < c+b && b < a+c && c < a+b) 
        Console.WriteLine("+");
    else 
        Console.WriteLine("-"); 
        
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c =Convert.ToInt32(Console.ReadLine());
Triangle(a,b,c);
