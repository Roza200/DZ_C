// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] RandomRealNumbersArray(int rows, int columns, int minValue,int maxValue)
{
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++)
       for(int j =0 ; j < columns; j++)
            newArray[i,j] = Math.Round(Convert.ToDouble(new Random().Next(minValue, maxValue + 1)) + new Random().NextDouble(), 1);     
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

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = RandomRealNumbersArray(m, n, min, max);
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
void SearchElementValueInArray(int[ ,] array,int row, int column)
{
    if (row < array.GetLength(0) && column < array.GetLength(1)) 
        Console.WriteLine($"Element with the parameters {row}, {column} is {array[row,column]}");
                     
    else Console.WriteLine($"Element with the parameters {row}, {column} not in the array");
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
SearchElementValueInArray(myArray, n1, m1);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

double[] ArithmeticMeanInColumn(int[,] array)
{   
    double[] averageArray = new double [array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
       double sum = 0;
       for(int i = 0; i < array.GetLength(0); i++)
       
          sum += array[i, j]; 
       averageArray[j] = Math.Round(sum / array.GetLength(0), 1);  
    }   
    return averageArray;
}

void ShowArray(double[] array)
{
   for(int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");
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

double[] arithmeticMeanInColumn = ArithmeticMeanInColumn(myArray);
Console.WriteLine("The verages of each column area: ");
ShowArray(arithmeticMeanInColumn);

*/
