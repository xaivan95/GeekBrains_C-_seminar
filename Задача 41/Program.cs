/// Задача 41
///Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
///

int[] array = GetNewArrayToConsole();

Console.Write("Количество положительных чисел равно {0}", GetPositivNumberToArray(array));
        
        static int[] GetNewArrayToConsole()
        {
            int[] arra = new int[0];
            //Получаем строки
            while (true)
            {
                string? s = Console.ReadLine(); //считали новую строку
                if (s.Equals("")) 
                { return arra; }//если пустая то выходим

                int newNumber;
                bool isNumberInt = Int32.TryParse(s, out newNumber);
                if (!isNumberInt)
                {
                    Console.WriteLine("Ошибка ввода");
                    return arra;
                }
                Array.Resize(ref arra, arra.Length + 1); //увеличиваем массив
                arra[arra.Length - 1] = newNumber;//записываем строчку
            }
        }

        static int GetPositivNumberToArray(int[] array)
        {
            return array.Count(x => x > 0);
        }