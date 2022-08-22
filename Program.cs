// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void vstep(double num, double up)
{
    Console.WriteLine ("Получится: " + Math.Pow(num, up));
}

Console.WriteLine("Введите число, которое нужно возвести в степень (А): ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число, которое будет степенью (B): ");
double B = Convert.ToDouble(Console.ReadLine());

vstep(A, B);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int youNumber = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (youNumber > 0)
{
    sum += youNumber % 10;
    youNumber /= 10;
}
Console.WriteLine (sum);