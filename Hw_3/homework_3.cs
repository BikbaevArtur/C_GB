//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
void Palindrom(int n)
{
    int temp = n;
    int result = 0;
    while(n > 0)
    {
        int dec = n%10;
        result = result * 10 + dec;
        n = n / 10 ;
    }
    if(temp == result)
        Console.WriteLine($"number: {temp} is palindrom");
    else 
        Console.WriteLine($"number{temp}: is not palindrom");

}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);





//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = (x2 - x1)*(x2 - x1);
    double y = (y2 - y1)*(y2 - y1);
    double z = (z2 - z1)*(z2 - z1);
    
    
    double dis = Math.Sqrt(x + y + z);
    return dis;
}

Console.WriteLine("Input X1, Y1, Z1 :");
double xCor1 = Convert.ToDouble(Console.ReadLine());
double yCor1 = Convert.ToDouble(Console.ReadLine());
double zCor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input X2, Y2, Z2 :");
double xCor2 = Convert.ToDouble(Console.ReadLine());
double yCor2 = Convert.ToDouble(Console.ReadLine());
double zCor2 = Convert.ToDouble(Console.ReadLine());
double result = Distance(xCor1,yCor1,zCor1,xCor2,yCor2,zCor2);
Console.WriteLine($"distance between points: {result :f2}");
*/

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*

void Cubes(int num)
{
    int st = 1;
    Console.Write($"{num} -> ");
    while(st <= num)
    {
        int cub = st * st * st;
        Console.Write(cub+ ", ");
        st++;
    }

}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Cubes(number);
*/