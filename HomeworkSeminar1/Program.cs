// Домашние задание к семинару 1 "Знакомство с языком программирования С#"

// Выполнил Артем Анатольевич Авдеев (know as Survivor of the SAO)


//================================================================================================================================
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
//--------------------------------------------------------------------------------------------------------------------------------
//Решение:

// Console.Write("Введите число A = ");
//     int numA=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число B = ");
//     int numB=Convert.ToInt32(Console.ReadLine());

// int[] bimassiv = {numA,numB};   // мне не интересно выполнять примитивные задания с if-else, т.к. у меня есть навыки кодера
// int maxValue = bimassiv.Max();  // поэтому, я извратился по-другому. Зацените!

// Console.WriteLine($"А вот и максимальное из них = "+maxValue);

//================================================================================================================================


//================================================================================================================================
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
//--------------------------------------------------------------------------------------------------------------------------------
//Решение: (Все тотже ..й только - трехчлен!)

// Console.Write("Введите число A = ");
//     int numA=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число B = ");
//     int numB=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число С = ");
//     int numС=Convert.ToInt32(Console.ReadLine());

// int[] trimassiv = {numA,numB,numС};   // мне не интересно выполнять примитивные задания с if-else, т.к. у меня есть навыки кодера
// int maxValue = trimassiv.Max();      // поэтому, я извратился по-другому. Зацените!

// Console.WriteLine($"А вот и максимальное из них = "+maxValue);

//================================================================================================================================


//================================================================================================================================
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
//--------------------------------------------------------------------------------------------------------------------------------
//Решение: (Ну, умею я работать с if-else, вот:)

// Console.WriteLine("Введите число : ");
// int numer = Convert.ToInt32(Console.Read());
// if (numer % 2 == 0) Console.WriteLine("Четное");
//     else Console.WriteLine("Нечетное");

//================================================================================================================================


//================================================================================================================================
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
//--------------------------------------------------------------------------------------------------------------------------------
//Решение: (И цикл For знаю)

Console.Write("Введите число : ");
int numa = Console.Read();
Console.WriteLine(numa);
Console.WriteLine($"Все четные числа от 2 до " + numa + ":");
for (int i = 1; i <= numa; i++)
{
   if (i % 2 == 0) Console.Write(i + ";");
}

//================================================================================================================================
 