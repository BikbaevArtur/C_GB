//Задача 1
//Напишите программу, которая принимает на вход число (A) и выдает сумму числе от 1 до A
/*
Мое решение задачи
int Summ(int number)
{
    int sum = 0;
   for(int n = 1; n <= number; n++)
   {
    sum = sum + n; // summ += n тоже самое как и до этого 
   }
   return sum;
   
   
}
int num = Convert.ToInt32(Console.ReadLine());
if( num > 0) int result = Summ(num);
else Console.WriteLine("-");
Console.Write(result);


// Задача 2
// Напишите программу, которая принимает на вход число, и выдает количестно цифр в числе

void ColNum (int num)
{   int count = 0;
    while(num > 0)
    {
        num = num/10;
        count ++;
    }
    Console.WriteLine($"number of digits: {count}");
}
Console.WriteLine("input number");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0) n=n * 1;
else n = n * -1;
ColNum(n);
как вариант добавить новую переменную для того что бы записать овую переменную 
Math.Abs почитать


//Задача 3
// Напишите программу, которая принимает на вход число N и выдаетпроизведение чисел от 1 до N

void Proz(int num)
{
    int result  = 1;
    for(int i = 1 ; i <= num; i++)
    {
    result = result * i; 
    }
    Console.WriteLine(result);
}
int number = Convert.ToInt32(Console.ReadLine());
Proz(number);
*/

// Задача 4 
// Напишите программу, которая выводит массив из 8 элементов 
// заполненная 0 , 1 в случайном порядке

int [] CreatNewArray (int size )
{
    int [] random01array = new int [size]; // создать переменную, будет хранит целые числа, будет массив, new int резервируем в памяти место
    for(int i = 0; i < size; i++)
    {
    random01array[i] = new Random().Next(0, 2);// правую часть не хватает
    }
    return random01array;   

}

void ShowCratArray (int [] array01)
{
    for(int i=0; i < array01.Length; i++)
    {
        Console.Write(array01[i] +" ");
    }
}
int [] arrayNew = CreatNewArray(8);
ShowCratArray(arrayNew);