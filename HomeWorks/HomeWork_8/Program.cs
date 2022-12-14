// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] OrderArrayLines(int[,] array)
{  
    for(int i = 0; i <  array.GetLength(0); i++)
       for(int j = 0; j < array.GetLength(1); j++)   
          for(int k = 0; k < array.GetLength(1) - 1; k++)
             if (array[i, k] > array[i, k + 1])
             {
               int temp = array[i, k];
               array[i, k] = array[i, k + 1];
               array[i, k + 1] = temp;
             }
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
Console.WriteLine();
Show2dArray(OrderArrayLines(myArray));
*/



//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
/*
int[,] CreateRandon2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0 ; j < columns; j++)
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
   Console.WriteLine();
}
int minSumInRow(int[,] array)
{
    int sum = 0;
    int indexLine = 0;
    int minSum = Int32.MaxValue;

    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)
             sum = sum + array[i, j];        
        if(sum < minSum)
        {
           minSum =  sum;
           indexLine++;
        }
    return indexLine;
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
minSumInRow(myArray);
int result = minSumInRow(myArray);
Console.WriteLine($"The smallest sum  of elements in a {result} row ");
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[ ,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if(matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for(int i = 0; i < matrix3.GetLength(0); i++)
        {
            for(int j = 0; j < matrix3.GetLength(1); j++)
            {
                //matrix3[i, j] = 0;
                for(int b = 0; b < matrix1.GetLength(1); b++)
                     matrix3[i, j] += matrix1[i, b] * matrix2[b, j];  
            }
        }
    }
    return matrix3;
}
Console.Write("Input number of rows in the first array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums in the first array : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of rows in the second array: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums in the second array : ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = CreateRandon2dArray(m, n, min, max);
int[,] secondArray = CreateRandon2dArray(m1, n1, min, max);
 
Show2dArray(firstArray);
Console.WriteLine();

Show2dArray(secondArray);
Console.WriteLine();

int[,] multiplicationMatrix = MultiplicationMatrix(firstArray, secondArray);
Show2dArray(multiplicationMatrix);

*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*

int[, ,] CreateRandon3dArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] newArray = new int[x, y, z];

    for(int i = 0; i < x; i++)
        for(int j =0 ; j < y; j++)
           for(int k = 0; k < z; k++)
            newArray[i,j,k] = new Random().Next(minValue, maxValue + 1);     
    
    return newArray;
}

void Show3dArray(int[, ,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
    for(int j = 0; j < array.GetLength(1); j++)
        for(int z = 0; z < array.GetLength(2); z++)
        Console.Write(array[i,j, z] + " ");

    Console.WriteLine();
   }
}
Console.Write("Input first point: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second point: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third point : ");
int z = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,,] newArray = CreateRandon3dArray(x, y, z, min, max);
Show3dArray(newArray);
*/




//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
/*
int[,] Spiral2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= newArray.GetLength(0) * newArray.GetLength(1))
         {
            newArray[i, j] = temp;
            temp++;
                if (i <= j + 1 && i + j < newArray.GetLength(1) - 1)
                      j++;
                else if (i < j && i + j >= newArray.GetLength(0) - 1)
                         i++;
                    else if (i >= j && i + j > newArray.GetLength(1) - 1)
                            j--;
                        else
                            i--;
        }
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

int[,] myArray = Spiral2dArray(m, n); 
Show2dArray(myArray);

*/












