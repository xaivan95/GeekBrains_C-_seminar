/// Задача 25
///Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
///

//Получаем числа
var stringA = Console.ReadLine();
var stringB = Console.ReadLine();
int A;
int B;
int resultat;

//Проверка входного числ
if (int.TryParse(stringA, out A) && int.TryParse(stringB, out B))
{
    //Возводим в степень
     resultat = GetPow(A,B);
}
else 
     {
        //Если строка введена с ошибкой
          Console.WriteLine("Входная строка не является числом");
          return;
     }

//Вывод результатов
Console.WriteLine(A + " в степени " + B + " равно "+resultat);

int GetPow(int A, int B)
     {
        int answer = A;
        if (B == 0) return 1;  else
        if (B == 1) return A;  else
            for (int i=2; i<=B;i++)
                A *= answer;
        return A;
     }