// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
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




//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]








//1. Программа, котрая принимает на вход число N  и возвращает сумму всех чисел от 1 до N
/*
int FindSum(int number)
{
   int sum = 0;

   for(int current = 1; current <= number; current++)

     sum = sum + current; // или sum += current;(увеличиваем на число + сумма)

  return sum;
}
Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindSum(a);
Console.WriteLine($"Sum of number from 1 to {a} is {result}");

//или, строку 16 удаляем в 17 переносим  результат FindSum(a) Console.WriteLine($"Sum of number from 1 to {a} is {FindSum(a)}");
*/

// 2. Программу, которая принимает на вход число и выдает количество цифр в числе
/*
int FindNumber(int number)
{
   int current = 0;
   while (number > 0 )
   {
     number = number / 10; 
     current++;
   }
   return current;
}

Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Digit of number from 1 to {a} is {FindNumber(a)}");
*/





// 3. Программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

/*
int FindFactorial(int number)
{
   int factorial = 1;

   for(int current = 1; current <= number; current++)

     factorial = current * factorial; 

  return factorial;
}
Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"P of number from 1 to {a} is {FindFactorial(a)}");
*/



// 4. Программу, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке 
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
 int[] newArray = new int[size];

 for(int i = 0; i < size; i++)
   newArray[i] = new Random().Next(minValue, maxValue + 1);
 return newArray;
}

void ShowArray(int[] array) // это метод вывода массива на экран
{
  for(int i =0; i < array.Length; i++)
     Console.Write(array[i] + " ");

  Console.WriteLine(); // пустая строка
}


Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value fo element: : ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);

ShowArray(myArray);
*/