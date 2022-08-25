// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
double FindX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
double FindY(double k1, double b1, double k2, double b2)
{
    double y = (k1 * (b2 - b1) / (k1 - k2) + b1);
    return y;
}
Console.WriteLine("Эта программа найдет точку пересечения двух прямых заданных уравнениями (y = k1 * x + b1, y = k2 * x + b2)");
Console.WriteLine("Введите k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Координаты пересечения двух прямых = " + FindX(k1, b1, k2, b2) + "; " + FindY(k1, b1, k2, b2));