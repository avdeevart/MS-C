//by Survivor of the SAO

// Рандомим 3х-значное число и удаляет вторую цифру этого числа 

// Random rand = new Random();
// int number = rand.Next(100,1000);
// System.Console.WriteLine(number);
// System.Console.WriteLine($"{number/100} {(number-((number/100)*100))-(((number-((number/100)*100))/10)*10)}");

//=================================================================================================================================

// Ввод 2 чисел. Проверять кратно ли второе чило первому

// Console.Write("Введите первое число: "); int numFist = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: "); int numSecond = Convert.ToInt32(Console.ReadLine());
// if (numFist%numSecond==0){Console.WriteLine($"Число:{numSecond} кратно числу:{numFist}");}
// else {Console.WriteLine($"Число:{numSecond} некратно числу:{numFist}");}

//=================================================================================================================================

// Вводим число и проверяем его кртаность числу 7 и 23

// Console.Write("Введите число: "); int numRef = Convert.ToInt32(Console.ReadLine());

// if (numRef%7==0 && numRef%23==0) {Console.WriteLine($"Число:{numRef} кратно одновременно числам:7 и 23");}
// else {Console.WriteLine($"Число:{numRef} некратно одновременно числам:7 и 23");}

//=================================================================================================================================

// Ввести  два числа и проверить не является ли одно из них квадратом другого, причем проверка в разных направлениях.

Console.Write("Введите первое число: "); int numFist = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: "); int numSecond = Convert.ToInt32(Console.ReadLine());

if (numFist*numFist==numSecond || numSecond*numSecond==numFist)
{
    Console.WriteLine($"Числа: {numFist} и {numSecond} являются квадратом одного другого");
}
else
{
     Console.WriteLine($"Числа: {numFist} и {numSecond} не являются квадратом одного другого");
}
//=================================================================================================================================