// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int s = 0;
while (N > 0)
{
    s = s + N % 10;
    N  /= 10;
}
Console.WriteLine(s);
