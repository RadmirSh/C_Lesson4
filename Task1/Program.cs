// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Please, write number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, write number B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
if (b<1)
Console.Write("The number B must be natural\n");
else
{
while (b!=0)
{
c = c * a;
b = b - 1;
}
Console.Write($"The number A in natural degree B is {c}");
}
