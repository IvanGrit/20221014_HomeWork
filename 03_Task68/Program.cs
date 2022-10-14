// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

using static System.Console;
Clear();

WriteLine("Вычисляем функцию Аккермана");
WriteLine("Введите значение числа N:");
int n = Convert.ToInt16(ReadLine());
WriteLine("Введите значение числа M:");
int m = Convert.ToInt16(ReadLine());

int meganumber = Akkermann(n, m);
WriteLine($"Результат вычисления функции Аккремана для аргументов {n} и {m} составляет {meganumber}.");




int Akkermann(int x, int y)
{
    if (x == 0) return y + 1;
    if (x > 0 && y == 0) return Akkermann(x - 1, 1);
    if (x > 0 && y > 0) return Akkermann(x - 1, Akkermann(x, y - 1));
    return Akkermann(x, y);
}
