/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/


int GetNumber()
{
    int result = 0;
    Console.WriteLine("Введите число:");
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число");
        }
    }

    return result;
}


int number = Math.Abs(GetNumber());
int sum = 0;
int num = number;

while (number != 0) 
{
    sum = sum + number % 10;
    number /= 10;
}
Console.WriteLine($"Сумма цифр в числе {num} равно {sum}");


