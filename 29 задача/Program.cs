/// Задача 29
///Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
///


string[] arrayString = new string[0];
//Получаем строки
while (true)
{
    string? s = Console.ReadLine(); //считали новую строку

    if (s.Equals("")) break;//если пустая то выходим

    Array.Resize(ref arrayString, arrayString.Length + 1); //увеличиваем массив
    arrayString[arrayString.Length-1] = s;//записываем строчку
}

 int[] arr = GetIntArray(arrayString); //преобразуем массив строк в массив чисел

if (arr.Length>0)
{
    //выводим массив чисел
    Console.Write("["+arr[0]);
    for (int i = 1; i<arr.Length; i++)
        Console.Write(","+arr[i]);
    Console.Write("]");
}
else
     Console.Write("Числа не введены");
//Конвертер массива строк в массив чисел
int[] GetIntArray(string[] A)
     {
        return A.Select(x => int.Parse(x)).ToArray();
     }