// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
void FiveDigitNumber(int number)

{
    int number5 = number % 10;
    int number4 = (number % 100) /10;
    int number2 = (number % 10000) /1000;
    int number1 = (number % 100000) /10000;
    
     if (number5 == number1 && number4 == number2)
     
       Console.WriteLine($"This number {number} is palindrome ");
    else
       Console.WriteLine($"This number {number} is not palindrome ");   
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
FiveDigitNumber(number);
*/



//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*

double Length(double x1, double y1, double z1, double x2, double y2, double z2)
{
     return  Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

Console.Write("Input x1: ");
double xA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y1: ");
double yA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input z1: ");
double zA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input x2: ");
double xB = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y2: ");
double yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2: ");
double zB = Convert.ToInt32(Console.ReadLine());


double len = Length(xA, yA, zA, xB, yB, zB);
Console.WriteLine("Length of the segment " + len);
*/





//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void CubeN(int num)
{
    for (int i = 1; i <= num; i++)
    {
        System.Console.Write(i*i*i + " ");
    }
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Cube numbers from 1 to "+ num +" is: ");
CubeN(num);
*/





