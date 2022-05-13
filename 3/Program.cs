/*Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.*/
Console.Write("Введите цифру дня недели:");
int number = Convert.ToInt32(Console.ReadLine());
if ((number < 8) && (number > 0))
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Это выходной день :-)");
    }
    else Console.WriteLine("Это будний день :-(");
}
else Console.WriteLine($"Попросил же цифру дня недели, их же 7, почему {number} !?");