﻿//Выполнил: Артем Анатольевич Авдеев (know as Survivor of the SAO & Master of Code Geass)
//___________________________________________________________________________________________________________________________________
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//===================================================================================================================================
//Решение:
//--------------------------------------------------------------------------------------------------------------------------
int GetDigitString(string txt)    // метод преобразует строку в число, при этом выводит задаваемый комментарий на консоль
{
System.Console.Write(txt);  //вывод комментария на консоль
return Convert.ToInt32(Console.ReadLine()); //вызов метода преобразования строки/целое число
}
//-----------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------
void DisplayArray (int [] myArray)  //метод выводящий содержимое массива в сторку
{
    System.Console.WriteLine($"[{string.Join(";",myArray)}]"); //крутой метод вывода массива. параметр1-сепаратор, пар2-сам массив
}
//-----------------------------------------------------------------------------------------------------------------------------------
int[] EnterArray(int size)  //вводим размер массива, возращаем массив данных введенных с консоли
{
    int[] entArray= new int [size];
    for(int a=0; a<entArray.Length;a++){entArray[a]=GetDigitString($"Введите элемент массива [{a}] = ");}
    return entArray;
}
//-----------------------------------------------------------------------------------------------------------------------------------
int SumIndexPositiveNumbers(int[] sourceArray)  //получает массив, возращает кол-во положительных чисел
{
    int sumIndex=0;
    for(int b=0; b<sourceArray.Length;b++)
    {
        if(sourceArray[b]>0){sumIndex++;}
    }
    return sumIndex;
}
//-----------------------------------------------------------------------------------------------------------------------------------
void DisplayAll()   //демонстрация всех условий и значений
{
    var temperArray = EnterArray(GetDigitString("Введите размер массива: "));
    DisplayArray(temperArray);
    Console.WriteLine($"Количество положительных чисел в массиве = {SumIndexPositiveNumbers(temperArray)}");
}
//-----------------------------------------------------------------------------------------------------------------------------------
//Поехали!
DisplayAll();