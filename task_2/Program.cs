// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputInt (string msg)
{
    int value;
    System.Console.Write($"{msg} -> ");
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Введенно неверное значение!");
    Environment.Exit(999);
    return 0;
}

(double, double) IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;
    return (x, y);
}

double k1 = InputInt("Ввежите коэффициент k1");
double b1 = InputInt("Ввежите коэффициент b1");
double k2 = InputInt("Ввежите коэффициент k2");
double b2 = InputInt("Ввежите коэффициент b2");
System.Console.WriteLine($"Точка {IntersectionPoint(k1, b1, k2, b2)} является точкой пересечения двух прямых, y={k1}x+{b1} и y={k2}x+{b2}");
