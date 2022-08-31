/// Задача 27
///Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
///

//Получаем числа
var stringA = Console.ReadLine();
int A;

//Проверка входного числ
if (int.TryParse(stringA, out A))
{
    //Возводим в степень
    int resultat = GetSummNumber(A);
}
else 
     {
        //Если строка введена с ошибкой
          Console.WriteLine("Входная строка не является числом");
          return;
     }

//Вывод результатов
Console.WriteLine("Сумма чисел в числе " + A + " равна "+resultat);

int GetSummNumber(int A)
     {
        int answer = 0;
        while (A>9)
        {
            answer +=A%10;
            A /= 10;
        }
        answer+=A;
        return answer;
     }