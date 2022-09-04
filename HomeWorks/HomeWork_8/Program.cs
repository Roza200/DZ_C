// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
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
   Console.WriteLine();
}


int[,] OrderArrayLines(int[,] array)
{  

    for(int i = 0; i <  array.GetLength(0); i++)
       for(int j = 0; j < array.GetLength(1); j++)
       
          for(int k = 0; k < array.GetLength(1) - 1; k++)
        
             if (array[i, k] < array[i, k + 1])
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






//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

// 1. Задать думерный массив.Программу , которая 
//поменяет местами первую и последнюю строки массива (делаем любую строоку с любой)
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
   Console.WriteLine();
}


int[,] ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= array.GetLength(0) && row2 >= array.GetLength(0))
        return array;
    else
    {
       for(int j = 0; j < array.GetLength(1) ; j++)
        {
           int temp = array[row1, j]; // временная переменнаяб в нее записали j из первой нужной нам строки
           array[row1, j] = array[row2, j];// присвоили элемент из второй строки
           array[row2, j] = temp;
        }
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

int[,] myArray = CreateRandon2dArray(m, n, min, max); // сгенерировали массив
Show2dArray(myArray);
myArray = ChangeRows(myArray, 0, m - 1);// m - 1 - это количетсво строк минус 1, m мы запросили выше
Show2dArray(myArray);
*/

// 2. Задайте двумерны массив. Напишите программу, которая заменяет строки на столбцы.
// в случае, когда это невозможно, программа должна вывести сообщение для пользователя
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
   Console.WriteLine();
}


int[,] ChangeRowsOnColumns(int[,] array)
{
    int temp = 0;
    if(array.GetLength(0) == array.GetLength(1))        
    {
       for(int i = 0; i < array.GetLength(0) - 1; i++)
              for(int j = i + 1; j < array.GetLength(1) ; j++)
              {
                temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
              }
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
ChangeRowsOnColumns(myArray);
Show2dArray(myArray);
*/

// 3. из двумерного массива целых чисел удалить строку и столбец, на пересечении которых
// расположен наименьший элемент
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
   Console.WriteLine();
}


int[,] DeleteRowColumn(int[,] array)
{
    int min = array[0, 0];
    int rowIndex = 0;
    int columnIndex = 0;
    for(int i = 0; i < array.GetLength(0); i++)
         for(int j = 0; j < array.GetLength(1); j++)
         {
            if(array[i, j] < min)
            {
                min = array[i, j];
                rowIndex = i;
                columnIndex = j;
            }

         }
    Console.WriteLine(min + " " + rowIndex + " " + columnIndex);
    Console.WriteLine();

    for(int i = 0; i < array.GetLength(0); i++)
         array[i, columnIndex] = 0;
    for(int j = 0; j < array.GetLength(1); j++)     
         array[rowIndex, j] = 0;
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
DeleteRowColumn(myArray);
Show2dArray(myArray);
*/