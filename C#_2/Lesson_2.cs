/*
int a1 =15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;
if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;
if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine($"max number: {max}");


// Пример с функцией

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 =15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(c3, b3, c3);
//int max = Max(max1, max2, max3);
int max =   Max ( Max(a1, b1, c1),
            Max(a2, b2, c2),
            Max(c3, b3, c3) ); //улучшенный вариант, функция в функии




Console.WriteLine($"max number: {max}");

Решение через массив

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int[] array = { 11, 211, 23, 45, 32, 55, 33, 22, 11 };
int max = Max(
          Max(array[0], array[1], array[2]),
          Max(array[3], array[4], array[5]),
          Max(array[6], array[7], array[8]));
Console.Write(max);


Поиск индекса в массиве

int[] array = {4, 5, 2, 6, 8, 121, 55, 213, 33};

int n = array.Length;
int find = 5;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        //breack; // если выполняется условие, прервать цикл, если есит одинаковые эллементы
        
    }
    index++;
}


Запись рандомного массива через метод


void FillArray(int[] collection) // метод заполнения массива
{
    int lenght = collection.Length; 
    int index = 0;
    while (index < lenght)
    {
        collection[index] =new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col) // метод по выводу массива
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]+" ");
        position++;
    }
}

int[] array = new int[10];

int IndexOf(int[] collection, int find) // Поиск  индекса числа
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 для того что бы, если нету элемента, выводил -1
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            
            
        }
        index++;
    }
    return position;

}

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos =IndexOf(array, 4);
Console.Write(pos);


// Задача 1.
// Напишите программу, которая получает на вход двузначное число и показывает наибольшую цифру числа.

Console.Write("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if(user_number > 9 && user_number < 100)
{
    int ed = user_number % 10;
    int dec = user_number / 10;
    int max = 0;
    if(ed > dec) max = ed;
    else max = dec;
    Console.WriteLine($"max number : {max}");
}

// решение задачи с помощью метода
int Digits (int number) // создали метод, нужно ввесли число
{
    int ed = number % 10;
    int dc =number / 10;
    
    if(ed > dc)
    {
        return ed;
    }
    else if (dc > ed)
            return dc;
        else
            return ed; 
}

Console.WriteLine("input 2digit numbe: ");
int user_number = Convert.ToInt32(Console.ReadLine());
int result;

if (user_number > 9 && user_number < 99)
{
    result = Digits ( user_number);
    Console.Write(result);
}
else
    Console.WriteLine("DUUUUD");
*/

//Задача 2.
// напишите программу которая выводит случайное число из отрезка [10, 99] и показывает найибольшую цифру чила.
//78 -> 8
//12 -> 2
//85 -> 8
// Решение задачи с методом с задачи 1 
/*
int Digits (int number) // создали метод, нужно ввесли число
{
    int ed = number % 10;
    int dc =number / 10;
    
    if(ed > dc)
    {
        return ed;
    }
    else if (dc > ed)
            return dc;
        else
            return ed; 
}

int r_number = new Random().Next(10, 99);
int maxDigit = Digits(r_number);


Console.WriteLine(r_number);
Console.WriteLine(maxDigit); 


int DigitalRandom()
{
    int r_number = new Random().Next(10, 100);
    Console.WriteLine($"random number {r_number}");
    int ed = r_number % 10;
    int dc = r_number / 10 ;
    if(ed>dc) return ed;
    else return dc;
    
}
int result = DigitalRandom();
Console.WriteLine($"max number: {result}");


// Задача 3
//Напишите программу, которая принимает на вход число и проверяет , кратно ли оно одновременно a и b. a,b  вводит пользователь

int n = Convert.ToInt32(Console.ReadLine());
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if(a % n == 0)
if(b % n == 0)
Console.WriteLine("+");
else Console.WriteLine("-");



void Devider (int numberToDevide, int dev1, int dev2)
{
    if(dev1 % numberToDevide == 0 && dev2 % numberToDevide == 0)
        Console.WriteLine("multiple number");
    else 
        Console.WriteLine("not multiple number");  
}
Console.WriteLine("input dividing number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input devisible number1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input devisible number2: ");
int b = Convert.ToInt32(Console.ReadLine());

Devider(n,a,b);





// Задача 4 
// Напшите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

int number = new Random().Next(99, 1000);
Console.WriteLine(number);
int ed = number / 100;
int sot = number % 10; // int n = ed * 10 + sot
Console.Write(ed);     // console.WriteLine(n);
Console.Write(sot);

int Random()
{
    int number = new Random().Next(99, 1000);
    Console.WriteLine(number);
    int ed = number / 100;
    int sot = number % 10;
    int n = ed * 10 + sot;
    return n;
}
int result = Random();
Console.WriteLine(result);

/*
//Задача 5
//Напишите программу, которая принмает два числа и проверяет, является ли одно число квадратом другого.
void Square(int fn, int sn)
{
    if(fn*fn == sn || sn * sn == fn)
        Console.WriteLine("+");
    else
        Console.WriteLine("-");
}
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
Square(firstNumber, secondNumber);   
*/


