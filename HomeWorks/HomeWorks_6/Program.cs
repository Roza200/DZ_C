// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] CreateArray(int size)
{
 int[] newArray = new int[size];

 for(int i = 0; i < size; i++)
 {
   Console.Write($"Input {i} elements of the array: ");
   newArray[i] = Convert.ToInt32(Console.ReadLine());
 }
 return newArray;
}

void ShowArray(int[] array) 
{
  for(int i =0; i < array.Length; i++)
     Console.Write(array[i] + " ");

  Console.WriteLine();
}

int QuantityNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > 0) count++;
    }
  return count;
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(a);

ShowArray(myArray);
QuantityNumbers(myArray);
int result = QuantityNumbers(myArray);

Console.WriteLine($"Quantity of numbers > 0 = {result} ");
*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = (k1 * x + b1);
Console.WriteLine($"The point of intersection of two straight lin:({x} ; {y} ");
*/