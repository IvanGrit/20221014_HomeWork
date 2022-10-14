// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

using static System.Console;
Clear();

WriteLine("Введите значение числа N:");
int n = Convert.ToInt16(ReadLine());
PrintNumbers(n);





void PrintNumbers(int x)
{
    Write(x+" ");
    if (x < 3) WriteLine("1.");
    else PrintNumbers(x - 1);
}
