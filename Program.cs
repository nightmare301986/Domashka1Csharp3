//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите число > ");          // Вывод приглашения ввода
string inputValue = Console.ReadLine();     // Ввод строки с терминала (с консоли)
int value = Convert.ToInt32(inputValue);    // Преобразование строки в число



    if (value%2 == 0) {
        System.Console.WriteLine("Число " + value + " является чётным."); 
    }
    else  
    {
       System.Console.WriteLine("Число " + value + " не является чётным.");
    }
