/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12   */


Console.WriteLine("Введите число ");
string number1Str = Console.ReadLine();
int number1 = Convert.ToInt32(number1Str);

int summa = 0;

while (number1 > 0)
{
    summa += number1 % 10;
    number1 /= 10;
}
Console.WriteLine(summa);


