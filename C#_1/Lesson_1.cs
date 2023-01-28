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
*/