int [] Array(int size , int minNum , int maxNum)
{
    int[] new_array = new int [size];
    for(int i=0; i < size; i++) new_array[i] = new Random().Next(minNum, maxNum +1);
    return new_array;
}

void ShowArray(int[] massiv)
{
    for(int i=0; i < massiv.Length; i++) Console.Write(massiv[i]+ " ");
}





// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void ResultDigits(int[] massiv)
{
    int count = 0;
    for(int i=0 ; i < massiv.Length; i++)
    {    
        if(massiv[i]%2 == 0) count += 1;
        else count += 0;
    }
    Console.WriteLine();
    Console.WriteLine($"the number of even numbers in array {count}");
}

/*


Console.WriteLine("Input size massiv: ");
int sizearray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the minimum three-digit number: ");
int minDigits = Convert.ToInt32(Console.ReadLine());
if(minDigits > 99 && minDigits < 1000)
{
    Console.WriteLine("enter the maximum three-digit number: ");
    int maxDigits = Convert.ToInt32(Console.ReadLine());
    if(maxDigits > 99 && maxDigits < 1000)
    {
        int [] arrayNew = Array(sizearray, minDigits, maxDigits);
        ShowArray(arrayNew);
        ResultDigits(arrayNew);
    }
    else
    { 
        Console.WriteLine("you entered a non-three-digit number");
    }

    
}
else
{ 
    Console.WriteLine("you entered a non-three-digit number");
}
*/






//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int SummOdd(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i]%2 != 0) sum = array[i]+sum;
        else sum += 0;
    return sum;
}

/*


Console.WriteLine("input size array: ");
int sizearray = Convert.ToInt32(Console.ReadLine());
Consol.WriteLine("input minDigit array: ");
int minDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input maxDigit array: ");
int maxDigit = Convert.ToInt32(Console.ReadLine());

int[] newArray = Array(sizearray, minDigit, maxDigit);
ShowArray(newArray);
int result = SummOdd(newArray);
Console.WriteLine($"summ of odd array numbers: {result}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. Math.Min Math.Max не использовать
//[3.0 7.1 22.5 2.7 78.8] -> 76.1



double [] ArrayDouble(int[] array)
{
    double[] new_array = new double [array.Length];
    for(int i=0; i < array.Length; i++) new_array[i] =array[i] + Math.Round(new Random().NextDouble(), 1);
    return new_array;
}
void ShowArrayDouble(double[] massiv)
{
    for(int i=0; i < massiv.Length; i++) Console.Write(massiv[i]+ " ");
}
void Difference (double[] massiv)
{
    double min = massiv[0];
    double max = massiv[0];
    for(int i = 1 ; i < massiv.Length; i++)
    {
        if(massiv[i]< min) min = massiv[i];
        if(massiv[i]>max) max = massiv[i];
        else i++;
    }
    Console.WriteLine();
    Console.WriteLine($"min digits = {min} max digits ={max}");
    Console.WriteLine($"Difference digits max & min = {Math.Round((max - min),1)}");
}

/*
Console.WriteLine("Inpun size array: ");
int sizearray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minDigit array: ");
int minDigit=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maxDigit array: ");
int maxDigit=Convert.ToInt32(Console.ReadLine());

int[] newArray = Array(sizearray, minDigit, maxDigit);
double[] arne = ArrayDouble(newArray);
ShowArrayDouble(arne);
Difference(arne);

*/
