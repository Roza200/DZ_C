// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int DegreeNumber(int numberA,int numberB)
{
   int result = 1;

   for(int i = 1; i <= numberB; i++)
   
    result = result * numberA;
   
  return result;
}
Console.Write("Input integer numberA: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer numberB: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} to the power of {b} equals {DegreeNumber(a, b)} ");

*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
/*
int FindSum(int number)
{ 
   int sum = 0;
   while (number > 0)
   {
    int num = number % 10;
    number = number/10;
    sum = sum + num;
   }  
   return sum;
}

Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of all the numbers from {a} is {FindSum(a)}");
*/


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
 int[] newArray = new int[size];

 for(int i = 0; i < size; i++)
   newArray[i]  = new Random().Next();// если я правильно понимаю, здесь надо ввести число, первое, второе и до воми. Как это сделать не знаю
 return newArray;
}

void ShowArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
     Console.Write(array[i] + " ");

  Console.WriteLine(); 
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(a);

ShowArray(myArray);

*/

