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
*/

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
