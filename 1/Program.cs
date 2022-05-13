/*Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.*/
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (((number - 100) < 0) || ((number - 1000) > 0))
{
    Console.WriteLine("Введенное число не трехзначное");
}
else
{
    int res = (number / 10) % 10;
    Console.WriteLine($"Вторая цифры введенного числа: {res}");
}