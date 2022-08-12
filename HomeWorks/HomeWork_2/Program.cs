
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

void ThirtDigit(int number)
{
    while (number >= 1000)
    {
        number = number / 10;
    }

    if (number <  99)
    {
        Console.WriteLine($" {number} does not have a third digit");   
    }
    else 
    {
        number = number % 10;
    }
    return number;       
} 

Console.WriteLine("Input numbur: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirtDigit = ThirtDigit(number);
Console.WriteLine($"The third digit of {number} is {thirtDigit} ");


/*int reminder = num2 % num1;

    if(reminder == 0)
        Console.WriteLine($"{num2} is IsDivisionabl of {num1} ");
    else
       Console.WriteLine($"{num2} is not IsDivisionabl of {num1}. Reminder is {reminder} ");  */ 











// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру этого числа
/*
int FindBiggestDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;
    int max;

    if(ed > dec)
        max =  ed;
    else
        max = dec;

    return max;

}


int randomNumber = new Random().Next(10, 100);

int beggestDigit = FindBiggestDigit(randomNumber);
Console.WriteLine($"Beggest digit of {randomNumber} is {beggestDigit}");
*/


 // Напишите программу, которая выводит случайное 3х значное число и удаляет вторую цифру этого числа
/*

 int CutNumber(int number)
 {
    int ed = number % 10;
    int sot = number / 100;

    return  sot * 10 + ed;

 }


 int randomNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randomNumber);
Console.WriteLine($"New version of {randomNumber} is {newNumber}");
*/

// Задача 3. Напишите прорамму, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число не кратно, то праграмма находит остаток от деления

/*
void IsDivisionable(int num1, int num2)
{
    int reminder = num2 % num1;

    if(reminder == 0)
        Console.WriteLine($"{num2} is IsDivisionabl of {num1} ");
    else
       Console.WriteLine($"{num2} is not IsDivisionabl of {num1}. Reminder is {reminder} ");     

}


Console.WriteLine("Input ferst numbur: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second numbur: ");
int n2 = Convert.ToInt32(Console.ReadLine());

IsDivisionable(n1, n2);
*/


//Задача 4. Напишите программу, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23.

/*
bool IsDivis(int number)
{
    if(number % 7  == 0 && number % 23 == 0)
       return true;
    else
       return false;
}

Console.WriteLine("Input numbur: ");
int n = Convert.ToInt32(Console.ReadLine());

bool isDivision = IsDivis(n);
Console.WriteLine(isDivision);
*/

// или записать так

/*
bool IsDivis(int number)
{
    return number % 7  == 0 && number % 23 == 0;  
}

Console.WriteLine("Input numbur: ");
int n = Convert.ToInt32(Console.ReadLine());

bool isDivision = IsDivis(n);
Console.WriteLine(isDivision);
*/