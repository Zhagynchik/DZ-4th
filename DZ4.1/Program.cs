/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16   */


Console.WriteLine("Введите число A");
string number1Str = Console.ReadLine();
int number1 = Convert.ToInt32(number1Str);

Console.WriteLine("Введите число B");
string number2Str = Console.ReadLine();
int number2 = Convert.ToInt32(number2Str);


if (number1>0 && number2>0)
{
    Console.WriteLine(Math.Pow(number1, number2));
}
else
{
    Console.WriteLine("Введите числа больше 0");
}

