/// Задача 21
///Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
///

//Первая точка
int x1; int y1; int z1;
Point3D point1;

//Вторая точка
int x2; int y2; int z2;
Point3D point2;

Console.WriteLine("Введите координаты первой точки");
bool isIntX1 = int.TryParse(Console.ReadLine(), out x1);
bool isIntY1 = int.TryParse(Console.ReadLine(), out y1);
bool isIntZ1 = int.TryParse(Console.ReadLine(), out z1);
point1 = new Point3D(x1, y1, z1);

Console.WriteLine("Введите координаты второй точки");
bool isIntX2 = int.TryParse(Console.ReadLine(), out x2);
bool isIntY2 = int.TryParse(Console.ReadLine(), out y2);
bool isIntZ2 = int.TryParse(Console.ReadLine(), out z2);
point2 = new Point3D(x2, y2, z2);

//Вывод результатов
if (isIntX1 && isIntY1 && isIntZ1 && isIntX2 && isIntY2 && isIntZ2)
    Console.WriteLine("Расстояние между точками = " + Math.Round(Distance(point1, point2),2).ToString());
else
    Console.WriteLine("Координаты введены не верно");

double Distance(Point3D p1, Point3D p2)
    {
        return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) 
                         + (p1.Y - p2.Y) * (p1.Y - p2.Y) 
                         + (p1.Z - p2.Z) * (p1.Z - p2.Z));
    }


public class Point3D
{
    public int X { get; }
    public int Y { get; }
    public int Z { get; }

    public Point3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}