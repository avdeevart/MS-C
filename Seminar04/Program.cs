﻿// Задача 24: На воде число А, а на выходе сумма чисел от 1 до А

int GetDigit(string txt)    // метод берет и выводит стоку (см.ср.9) и возращает целое число с консоли
{
System.Console.Write(txt);
return Convert.ToInt32(Console.ReadLine());
}
   
// int num = GetDigit("Введите целое цисло А: ");
   
int SumResult (int num)     //метод принимающий число А и возращающий сумму, по условию задачи
{
    int result = 0;
    for(int i=1; i <= num; i++ ) {result +=i;}
    return result;
}

System.Console.WriteLine($"Результат суммы от 1 до A: {SumResult(GetDigit("Введите целое цисло А: "))}");

