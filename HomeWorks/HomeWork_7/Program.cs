// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] RandomRealNumbersArray(int rows, int columns)
{
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++)
       for(int j =0 ; j < columns; j++)
            newArray[i,j] = new Random().NextDouble()*10;     
    return newArray;
}
void Show2dArray(double[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
    for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");

    Console.WriteLine();
   }
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = RandomRealNumbersArray(m, n);
Show2dArray(myArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandon2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j =0 ; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);        
    return newArray;
}

void Show2dArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
    for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
    Console.WriteLine();
   }
}
bool SearchElementValueInArray(int[] array,int row, int column)
{
    if (row < array.GetLength(0) && column < array.GetLength(1)) return true;
          
     //else return false;     
    else Console.WriteLine($"Element with the parameters{row}{column} not in the array");
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of row: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colum: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandon2dArray(m, n, min, max);
Show2dArray(myArray);

bool result = SearchElementValueInArray();
if (result == false) Console.WriteLine($"Element with the parameters{n1}{m1} not in the array");
else Console.WriteLine($"The { m1}, {n1}  array");
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] CreateRandon2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j =0 ; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);     
    
    return newArray;
}

void Show2dArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
    for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");

    Console.WriteLine();
   }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandon2dArray(m, n, min, max); 
Show2dArray(myArray);





// 3. Создать двумерный массив, найти элементы у которых оба индекса четные и заменить их на квадраты
/*
int[,] CreateRandon2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j =0 ; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);     
    
    return newArray;
}

void Show2dArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
    for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");

    Console.WriteLine();
   }
}
int[,] ChangeElementsOfArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i+=2)
        for(int j = 0 ; j < array.GetLength(1); j+=2) // j++ заменили на j+=2 нашли четные числа
             array[i,j] = array[i,j] * array[i,j];
    
    return array;
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandon2dArray(m, n, min, max); 
Show2dArray(myArray);
ChangeElementsOfArray(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/

// 4. Задать двумерный массив и найти сумму элементов, находящихся на главной диагонали
/*
int[,] CreateRandon2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j =0 ; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);     
    
    return newArray;
}

void Show2dArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
    for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");

    Console.WriteLine();
   }
}
int SumOfElementsOfArray(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
       sum = sum + array[i,i];
    }
    
    return sum;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandon2dArray(m, n, min, max); 
Show2dArray(myArray);
int sum = SumOfElementsOfArray(myArray);
Console.WriteLine($"Sum of elemeyts of array of main diagonale is {sum}");
*/



