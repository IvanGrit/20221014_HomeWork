// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

using static System.Console;
Clear();

WriteLine("Введите значение числа N:");
int n = Convert.ToInt32(ReadLine());
WriteLine("Введите значение числа M:");
int m = Convert.ToInt16(ReadLine());
int z = 0;
if (n > m) { int temp = n; n = m; m = temp; };
int sum = FindSum(n, m);
WriteLine($"Сумма чисел от {n} до {m} составляет {sum}.");








int FindSum(int x, int y)
{
    z += x;
    if (x == y) return z;
    else return FindSum(x+1, y);
    
}