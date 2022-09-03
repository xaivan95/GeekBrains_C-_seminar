/// Задача 38
///Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
///

//Размер массива
int lenght;
int min;
int max;

Console.Write("Введите размерность массива: ");
bool isLenghtInt = Int32.TryParse(Console.ReadLine(), out lenght);
Console.Write("Введите нижнюю границу диапазона: ");
bool isMinInt = Int32.TryParse(Console.ReadLine(), out min);
Console.Write("Введите верхнюю границу диапазона: ");
bool isMaxInt = Int32.TryParse(Console.ReadLine(), out max);


//Если данные корректны
if (isLenghtInt)
{
double[] array = new double[lenght]; //инициализируем массив
array = GetRandomArray(lenght, min, max);//заполняем массив
PrintArray(array);//выводим массив
Console.WriteLine("Разница между максимальным и минимальным элементом массива равна: " + GetDifference(array));//выводим колличество четных чисел
}
else
     Console.Write("Ошибка ввода");



//метод заполнения рандомными числами массива
double[] GetRandomArray(int lengh, int min, int max)
{
    var arr = new double[lengh];
    Random rnd = new Random();

    for (int i = 0; i<lengh; i++)
        arr[i] = Math.Round(rnd.NextDouble()*(max-min)+min,2);

    return arr;
}
//печать массив в консоль
void PrintArray(double[] arr)
{
    for (int i=0;i<arr.Length-1;i++)
        Console.Write(arr[i] + "; ");
      Console.Write(arr[arr.Length-1]);
          Console.WriteLine();
}
//считаем сумму элементов на нечетных позициях
double GetDifference(double[] arr)
{ 
    return Math.Round(GetMaxElement(arr) - GetMinElement(arr),2);
}

double GetMaxElement(double[] arr)
{
    double max = arr[0];

    for (int i = 0; i<arr.Length;i++)
        if (arr[i]>max) max = arr[i];
    return max;
}

double GetMinElement(double[] arr)
{
    double min = arr[0];

    for (int i = 0; i<arr.Length;i++)
        if (arr[i]<min) min = arr[i];
    return min;
}