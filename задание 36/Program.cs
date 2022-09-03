/// Задача 36
///Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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
if (isLenghtInt && isMinInt && isMaxInt)
{
int[] array = new int[lenght]; //инициализируем массив
array = GetRandomArray(lenght, min, max);//заполняем массив
PrintArray(array);//выводим массив
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях: " + GetOddPositions(array));//выводим колличество четных чисел
}
else
     Console.Write("Ошибка ввода");



//метод заполнения рандомными числами массива
int[] GetRandomArray(int lengh, int min, int max)
{
    var arr = new int[lengh];
    Random rnd = new Random();

    for (int i = 0; i<lengh; i++)
        arr[i] = rnd.Next(min,max);

    return arr;
}
//печать массив в консоль
void PrintArray(int[] arr)
{
    for (int i=0;i<arr.Length-1;i++)
        Console.Write(arr[i] + ",");
      Console.Write(arr[arr.Length-1]);
          Console.WriteLine();
}
//считаем сумму элементов на нечетных позициях
int GetOddPositions(int[] arr)
{ 
    int summ = 0;
    for (int i=1;i<arr.Length;i++)
       if (i%2==1) summ+=arr[i];
    return summ;
}