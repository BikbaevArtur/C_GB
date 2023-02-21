//Напишите программу который перевернет одномерный массив
//



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
