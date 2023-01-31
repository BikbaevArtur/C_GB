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
*/

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




