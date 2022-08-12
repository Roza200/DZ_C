
/*
// Задача 10.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int CutNumber(int number)

{
    int ed = number % 10;
    int dec = number % 100;
    return (dec - ed) / 10;
}

int randomNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randomNumber);
Console.WriteLine($"New version of {randomNumber} is {newNumber}");
*/





// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void ThirtDigit(int number)
{
    while (number >= 1000)
    {
        number = number / 10;
    }

    if (number <  100)
         Console.WriteLine($" {number} does not have a third digit");  
    
    else 
       Console.WriteLine($" a third digit {number % 10} ");     
} 

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

ThirtDigit(number);
*/


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void DayWeek(int dayNumber)
{
    if (dayNumber >= 6)
      Console.WriteLine($"This day {dayNumber} is a day off ");
    
    else
      Console.WriteLine($"This day {dayNumber} is not a day off ");   
}

Console.WriteLine("Input number of the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

DayWeek(dayNumber);

*/






