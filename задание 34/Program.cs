/// Задача 34
///Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
///

//Размер массива
int lenght;
Console.Write("Введите размерность массива: ");

bool isLenghtInt = Int32.TryParse(Console.ReadLine(), out lenght);
//Если данные корректны
if (isLenghtInt)
{
int[] array = new int[lenght]; //инициализируем массив
array = GetRandomArray(lenght);//заполняем массив
PrintArray(array);//выводим массив
Console.WriteLine("Колличество четных чисел равно: " + GetPositivNumber(array));//выводим колличество четных чисел
}
else
     Console.Write("Ошибка ввода");

//метод заполнения рандомными числами массива
int[] GetRandomArray(int lengh)
{
    var arr = new int[lengh];
    Random rnd = new Random();

    for (int i = 0; i<lengh; i++)
        arr[i] = rnd.Next(100,999);

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
//считаем колличество четных чисел
int GetPositivNumber(int[] arr)
{ 
    int count = 0;
    for (int i=0;i<arr.Length;i++)
        if (arr[i]%2==0) count++;
    return count;
}