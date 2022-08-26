/// Задача 21
///Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
///

//Число N
int N;

Console.WriteLine("Введите число");
bool isIntN = int.TryParse(Console.ReadLine(), out N);

//Вывод результатов
if (isIntN)
    Console.WriteLine(GetCubeRyad(N));
else
    Console.WriteLine("Не верные входные данные");

string GetCubeRyad(int N)
    {
        if (N==0) return "0";
        if (N==1) return "1";
        if (N==-1) return "-1";
        if (N>1)
        {
            string s = "1";
            for (int i=2;i<=N;i++)
                 s+="," + Math.Pow(i,3).ToString();
            return s;
        }
        if (N<-1)
        {
            string s = "-1";
            for (int i=-2;i>=N;i--)
                 s+="," + Math.Pow(i,3).ToString();
            return s;
        }
        return "";
    }

