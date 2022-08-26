/// Задача 19
///Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
///

//Получаем число
var input = Console.ReadLine();
int x;
bool isPalindrom = false;

//Проверка входного числа
if (int.TryParse(input, out x))
{
     isPalindrom = GetIsPalindrom(input);
}
else 
     {
          Console.WriteLine("Входная строка не является числом");
          return;
     }

//Вывод результатов
if (isPalindrom) Console.WriteLine("да");
else Console.WriteLine("нет");

bool GetIsPalindrom (string stroka)
     {
          for (int i = 0; i < stroka.Length / 2; i++) 
                if (stroka[i] != stroka[stroka.Length - i - 1])
                     return false;
          return true;
     }