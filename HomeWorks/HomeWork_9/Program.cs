//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void Numbers(int n, int m)
{
    if(m != n)
        if(n > m)
        {
            Numbers(n-1, m);
            Console.WriteLine(n + " ");
        }
        else
        {
            Numbers(m - 1, n);
            Console.WriteLine(m + " " );
        }  
    else
    Console.WriteLine(m + " ");    
}  
Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b= Convert.ToInt32(Console.ReadLine()); 
Numbers(a, b);
*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int sumNumbers(int n, int m)
{
    if(m!=n)
    {
        if(m > n)
           return n + sumNumbers(n+1, m);
        else
           return m + sumNumbers(n, m + 1);
    }
    else
         return m;
}

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b= Convert.ToInt32(Console.ReadLine()); 

int sum = sumNumbers(a, b);
Console.WriteLine($"sum of all numbers {a} and {b} = {sum} ");
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Ackerman(int n, int m)
{
    if(n == 0) return m + 1;
       if(n != 0 && m == 0) return Ackerman(n - 1, 1);
       else
       {
         return Ackerman(n - 1, Ackerman (n, m - 1));
       }
    
}
Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b= Convert.ToInt32(Console.ReadLine()); 

int ackerman = Ackerman(a, b);
Console.WriteLine($"The ackerman function is {ackerman} ");
*/