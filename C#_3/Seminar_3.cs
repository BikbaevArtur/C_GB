// Задача 1 
// Напишите программу, которая принимает на вход координаты точки X, Y,
// причем X != 0 Y != 0 и выдает  номер четверти плоскости, в которой находится эта точка
/*
void Hem(int X, int Y)
{   
   
    if(X > 0 || Y > 0) Console.WriteLine("I");
    else if(X < 0 || Y > 0) Console.WriteLine("II");
    else if(X < 0 || Y < 0) Console.WriteLine("III");
    else if(X > 0 || Y < 0) Console.WriteLine("IV");
    else Console.WriteLine("ERROR");
    
}
 Console.WriteLine("Input X: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input Y: ");
    int y1 = Convert.ToInt32(Console.ReadLine());

Hem(x1,y1);
*/

//Задача 2.
//Напишите программу, которая по заданному номеру четверти 
//показывает диапазон возможных координат точек этой четверти(X и Y).

/*

void Cor(int qarter)
{
    if(qarter == 1) Console.WriteLine("range X > 0 && Y > 0");
    else if(qarter == 2) Console.WriteLine("range X <0 && Y >0");
    else if(qarter == 3) Console.WriteLine("range X <0 && Y< 0");
    else if(qarter == 4) Console.WriteLine("range X >0 && Y < 0");
    else Console.WriteLine("ERROR");
}

Console.WriteLine("Input qarter:");
int qar = Convert.ToInt32(Console.ReadLine());
Cor(qar);


// Задача 3 
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2 D пространстве


double Dell(double x1, double y1, double x2, double y2)
{   
    double num = (x2 - x1)*(x2 - x1) + (y2 - y1) * (y2 - y1);
    double m = Math.Round(Math.Sqrt(num),3);//Math.Round() это округление на 3 запятые
    return m;
}


Console.WriteLine("Input cordinat first point");
Console.Write("xCor1:");
double xCor1 = Convert.ToDouble(Console.ReadLine());
Console.Write("yCor1: ");
double yCor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input cordinat second point");
Console.Write("xCor2: ");
double xCor2 = Convert.ToDouble(Console.ReadLine());
Console.Write("yCor2: ");
double yCor2 = Convert.ToDouble(Console.ReadLine());
double result = Dell(xCor1, yCor1,xCor2 ,yCor2);
Console.WriteLine($"Dell = {result}"); // {result :f2}// так же можно использовать что бы после запятой показывать 2 цифры с округлением

// Задача 4 
// Напишите программу, которая принимает на вход число N и 
// выдает таблицу квадратов от 1 до N.

void Tabl (int n)
{int b = 1;
while(b <= n)
{   int v = b * b * b;
    Console.Write(v+", ");
    b++;
}
}
int num = Convert.ToInt32(Console.ReadLine());
Tabl(num);
*/

/*

Вид 1 Не возвращает, и не принимает аргументы
void Method1()
{
    console.WriteLine("Autor..");
}
Metod(); 

Вид 2 Не возвращает, но принимает аргументы

void Method2(string msg, int count )
{ 
    int i = 0
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}   

Method2(msg:"Текст сообщения",4); цикл на сообщения 4 раза 
можно приписывать к аргументам значения 
Инкремент это увеличение в цикле ++
Дескримент Уменьшение в цикле --

Вид 3 Возвратный метод

int Method3()
{
    return DateTime.Now.Year; указывает дата
}

int year = Method3();
Console.WriteLine(year );

цикл for () собирает все в 1 месте, и инициализацию, и условие
int i = 0;
string result = String.Empty; обозначение пустой строчки, это тупо что бы поняли, хороший тон

int Method4(int adsa)
{   
    int i = 0;
    string result = String.Empty

    while( i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}   
int asd = method 4
cosole.writeline(asd)

======= тоже самое с for
int Method4(int adsa)
{   
    string result = String.Empty;
    for (int i = 0; i<count; i++)
    {
        result = result + text;
    }
}   
int asd = method 4
cosole.writeline(asd)
*/
//  == Работа с текстом 
// Дан текст. В тексте  нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить на маленькие "с".


//string s ="qwerty"
//           012345 как массив
// s[3]= r
/*
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght ; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string text = "-Я думаю,- сказал князь, улыбаясь, -что "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
*/

int[] arr = {1, 5, 4, 3, 2, 6, 7, 7, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i] }");
    }
    Console.WriteLine();
}
PrintArray(arr);



