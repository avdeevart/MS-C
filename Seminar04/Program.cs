﻿// // Задача 24: На воде число А, а на выходе сумма чисел от 1 до А
// //-------------------------------------------------------------------------------------------------------------------------------
// int GetDigit(string txt)    // метод берет и выводит стоку (см.ср.9) и возращает целое число с консоли
// {
// System.Console.Write(txt);
// return Convert.ToInt32(Console.ReadLine());
// }
// //--------------------------------------------------------------------------------------------------------------------------------   
// //   int SumResult (int num)     //метод принимающий число А и возращающий сумму, по условию задачи
// // {
// //     int result = 0;
// //     for(int i=1; i <= num; i++ ) {result +=i;}
// //     return result;
// // }
// // //--------------------------------------------------------------------------------------------------------------------------------
// // System.Console.WriteLine($"Результат суммы от 1 до A: {SumResult(GetDigit("Введите целое цисло А: "))}");

// //===================================================================================================================================
// // Задача 26: На воде число , а на выходе - количество цифр в числе + Задача 28: Расчет факториала
// //-------------------------------------------------------------------------------------------------------------------------------
// int NumberOfDigits(string txt)  //метод опреледеления разрядности числа
// {
//     int numbers=txt.Length; return numbers;
// }
// //-------------------------------------------------------------------------------------------------------------------------------
// string GetString(string txt)    // метод берет и выводит стоку, затем возращает введенную строку с консоли
// {
// System.Console.Write(txt);
// return Convert.ToString(Console.ReadLine());
// }
// //-------------------------------------------------------------------------------------------------------------------------------
// int Factorial(int n)     //метод вычисления факториала
// {
//     int m=1;
//     for(int l=1; l<=n; l++){m=m*l;}
//     return m;
// }
// //-------------------------------------------------------------------------------------------------------------------------------

// System.Console.WriteLine($"Количество цифр в числе: {NumberOfDigits(GetString("Введите целое цисло: "))}");
// System.Console.WriteLine($"Факториал числа будет: {Factorial(GetDigit("Введите целое цисло для расчета факториала: "))}");
// //===================================================================================================================================
// Задача 30: программа должна вывести массив из 8 элементов, заполненный 0/1 в случайном порядке.

void BinaryRoundArray()     //метод заполнения массива рандомным бинарным кодом
{
    var biRand = new Random();        //объявление рандомной переменной
    var binaryArray = new int [8];   //объявление массива на 8 элементов
    
    for (int s=0; s<binaryArray.Length; s++)            //заполнение массива случайными бинарными значениями
    {
        binaryArray[s]=biRand.Next(0,2); //внимани 2-не входит в границу правого диапазона (n-1)
        // System.Console.Write($"{binaryArray[s]};");
    }
    System.Console.Write($"Массив:[{string.Join("|",binaryArray)}]"); //крутой метод вывода массива. параметр1-сепаратор, пар2-сам массив
}

BinaryRoundArray();
