// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*

int[] CreateRandomArray(int size)
{
 int[] newArray = new int[size];

 for(int i = 0; i < size; i++)
   newArray[i] = new Random().Next(100, 1000);
 return newArray;
}

void ShowArray(int[] array) 
{
  for(int i = 0; i < array.Length; i++)
     Console.Write(array[i] + " ");

  Console.WriteLine(); 
}

int PositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
            
    }  
    return count;
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a);

ShowArray(myArray);
PositiveNumber(myArray);
int result = PositiveNumber(myArray);

Console.WriteLine($"In the array positive numbers - {result} ");
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
 int[] newArray = new int[size];

 for(int i = 0; i < size; i++)
   newArray[i] = new Random().Next(minValue, maxValue + 1);
 return newArray;
}

void ShowArray(int[] array) 
{
  for(int i = 0; i < array.Length; i++)
     Console.Write(array[i] + " ");

  Console.WriteLine(); 
}

void FindSumOddPositions(int[] array)
{
    int sumOdd = 0;
    for (int i = 0; i < array.Length; i+=2)
      sumOdd += array[i];
   Console.WriteLine("Sum of elements standing in odd positions = " + sumOdd);
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value fo element: : ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);

ShowArray(myArray);
FindSumOddPositions(myArray);
*/




//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
 int[] newArray = new int[size];

 for(int i = 0; i < size; i++)
   newArray[i] = new Random().Next(minValue, maxValue + 1);
 return newArray;
}

void ShowArray(int[] array) 
{
  for(int i = 0; i < array.Length; i++)
     Console.Write(array[i] + " ");

  Console.WriteLine(); 
}
  
void FindDifferenceMinMax(int[] array)
{
  int maxNumber = array[0];
  int minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
      if( array[i] > maxNumber)
      {
          maxNumber = array[i];
      }
      if ( array[i] < minNumber )
      {
          minNumber = array[i];
      }
    }
    Console.WriteLine($"Max = {maxNumber}, Min = {minNumber}");
    Console.WriteLine($"The difference between the max and min elements of array = {maxNumber - minNumber}");
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value fo element: : ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);

ShowArray(myArray);
FindDifferenceMinMax(myArray);
*/

