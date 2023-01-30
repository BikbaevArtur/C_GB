/* dotnet new console - создать новый проект 
dotnet run - запустить проект
Console -обращение к консоли 
Console.WriteLine - обращение к консоли что для вывода
string username = Console.ReadLine(); - задать переменную которую надо ввести string - обозначение вида данных
Console.Write(); - вывод без новой строчки
int - обозначение целых чисел

пример 
int numberA = 3;
int numberB = 4;
Console.Write(numberA + numberB);
double - для вещественных чисел, например 2.5
bool - тип данных true/false
new Random().Next(min, max)- новое случайно число в диап от мин до макс, дает целое число, от min до max-1

Пример 

int numberA = new Random().Next(-10, 10);
int numberB = new Random().Next(-10, 10);
Console.Write(numberA + numberB);
можно дописать Console.Write(numberA); - для того что бы вывести то число , которое загадали

Пример:

Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if(username.ToLower() == "маша") // username.ToLower() нижний регистр, при написании маленькими буквами, выводит правильно
{
    Console.WriteLine("Привет дорогая Маша");
} 
else {
    Console.Write("Привет ");
    Console.Write(username);
}
 Приме нахождение максимума 
 
int a = 1;
int b = 3;
int c = 6;
int d = 8;
int e = 10;
int max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d ;
if (e > max) max = e;
Console.Write(max);


рисование херни, разобраться пошагово 


int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30 ;


Console.SetCursorPosition(xa, ya); // отступы 
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb); // отступы 
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc); // отступы 
Console.WriteLine("+");

int x = xa, y= xb;
int count = 0;
while (count < 10000)
{
    int what = new Random().Next(0, 3); //определение точек, нихера не понял как программа находит точки
    if(what==0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }

    if(what==1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }

    if(what==2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
int number = 26
Console.WriteLine("My number is"+number+"| I like it|");
Console.WriteLine($"Mt number is {number}| I like it is"|); лучше писаить так

number = Console.ReadLine(); - не конвертированное значение
int number = Convert.ToInt32(Console.ReadLine()); -конвертированное значение
читается справно налево, тобишь ввод=>конверт=>присвоение number


//Задача 1.
//Напишите программу, которая на вход принимает число, и выдает его квадрат

int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number*number);


// Задача 3
//Напишите программу на вход принимает два числа, и проверяет
//является ли первое число квадратром второго. 

Console.WriteLine("Введите первое число:");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number_2 = Convert.ToInt32(Console.ReadLine());
int resul=number_1 / number_2;
if(resul == number_2)
    Console.WriteLine($"Первое число является квадратом {number_2}" );
else
    Console.WriteLine($"Первое число не является квадратом {number_2}" );

Задача 5.
Напишите программу, которая на входе принимает одно число (N),
а на выходе показывает все целые числа в промежутке от -N до N
   

Console.Write("Input your number N:");
int number = Convert.ToInt32(Console.ReadLine());
int current_num = number * (-1);
while (current_num <= number)
{
    Console.Write(current_num + " ");
    current_num++; 
}

Задача 7.
Напишите программу, которая на входе принимает трехзначное число, и на выходе показывает последнюю цифру этого числа 

 

 Console.Write("Введите трехзначное число:");
 int num = Convert.ToInt32(Console.ReadLine());
 if (num >99 && num< 1000
    ) // оперсант 
 {
    int result = num % 10;
    Console.WriteLine($"Последняя цифра числа {num} : {result}");
 }
 else
 {
    Console.WriteLine("Число не трехзначное ");
 }
 */

 

 