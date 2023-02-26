﻿//Выполнил: Артем Анатольевич Авдеев (know as Survivor of the SAO & Master of the Geass)
//___________________________________________________________________________________________________________________________________
// Задача 62: Заполните спирально массив 4 на 4.
//===================================================================================================================================
//Решение:
//-----------------------------------------------------------------------------------------------------------------------------------
int GetDigitString(string txt)    // метод преобразует строку в число, при этом выводит задаваемый комментарий на консоль
{
    System.Console.Write(txt);  //вывод комментария на консоль
    return Convert.ToInt32(Console.ReadLine()); //вызов метода преобразования строки/целое число
}
//-----------------------------------------------------------------------------------------------------------------------------------
void Display2DArray(int[,] myArray)  //метод выводящий содержимое массива в сторку
{
    System.Console.WriteLine();

    for (int i = 0; i < myArray.GetLength(0); i++) //GetLength(0)-метод, возращающий длину массива в первом("0") пространстве("i")
    {
        for (int j = 0; j < myArray.GetLength(1); j++)    //GetLength(1)-метод,возращающий длину массива во втором("1")пространстве("j")
        {
            System.Console.Write(myArray[i, j] + "\t"); //использование табуляции для выравнивания вывода -("\t")
        }

        System.Console.WriteLine(); //пустая строка позволяет вывести построчно 
    }
}
//-----------------------------------------------------------------------------------------------------------------------------------
int[,] GenerateSpiralArray(int size)   //генератор квадратного массива заполняемого последовательно от 1 по часовой стрелке
{
    int[,] spiralArray = new int[size, size];
    int m=size, row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;

    for (int i = 0; i < spiralArray.Length; i++)
    {
        spiralArray[row, col] = i + 1;
        if (--gran == 0)
        {
            gran = m * (dirChanges % 2) + size * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
    return spiralArray;
}
//-----------------------------------------------------------------------------------------------------------------------------------
void DisplayAll()
{
    System.Console.WriteLine();
    Display2DArray(GenerateSpiralArray(GetDigitString("Введите размер квадратного массива:")));
    System.Console.WriteLine();
}
//-----------------------------------------------------------------------------------------------------------------------------------

DisplayAll();

