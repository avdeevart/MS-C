﻿// By Survivor of the SAO
// Вводим координаты точки x,y а получаем номер четверти, где эта точка находится.
// Делаем через свои функции-методы
// ____________________________________________________________________________________________________________________________________

int InputCord(string str)   // объявление метода ввода координат
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
// ____________________________________________________________________________________________________________________________________

void Find4t(int corX, int corY) //объявляем метод,который ни чего не возращает, только выводит результат (четверть)
{
if (corX==0 || corY==0) {Console.WriteLine($"Вы ввели нулевое значение! Х={corX}; Y={corY}! Нулевых значений не должно быть!");}

if (corX>0 && corY>0) {Console.WriteLine($"Первая четверть");}
    else
    {
        if (corX<0 && corY>0) {Console.WriteLine($"Вторая четверть");}
            else
            {
                if (corX>0 && corY<0) {Console.WriteLine($"Третья четверть");}
                    else {Console.WriteLine($"Четвертая четверть");}
            }

    }
}

// ____________________________________________________________________________________________________________________________________

int X= InputCord("Введите координату (не нулевое значение) Х = ");
int Y= InputCord("Введите координату (не нулевое значение) Y = ");

Find4t(X,Y);
Find4t(-3,-5);