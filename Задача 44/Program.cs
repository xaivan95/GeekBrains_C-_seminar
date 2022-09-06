/// Задача 43
///Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
///

double k1;
Console.Write("Введите коэффициент первого уравнения: ");
bool isNumber_k1 = double.TryParse(Console.ReadLine(), out k1);

double b1;
Console.Write("Введите добавочный коэффициент первого уравнения: ");
bool isNumber_b1 = double.TryParse(Console.ReadLine(), out b1);

double k2;
Console.Write("Введите коэффициент второго уравнения: ");
bool isNumber_k2 = double.TryParse(Console.ReadLine(), out k2);

double b2;
Console.Write("Введите добавочный коэффициент второго уравнения: ");
bool isNumber_b2 = double.TryParse(Console.ReadLine(), out b2);

if (isNumber_k1 && isNumber_k2 && isNumber_b1 && isNumber_b2)
{
    GetRatioOfSegments(k1, b1, k2, b2);
}
else
    Console.WriteLine("Ошибка ввода исходных данныъх");



static void GetRatioOfSegments(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2) Console.WriteLine("Прямые параллельны");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine("x = {0}, y = {1}", x, y);
    }
}