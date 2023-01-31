// Рандомим 3х-значное число и удаляет вторую цифру этого числа //by Survivor of the SAO

// Random rand = new Random();
// int number = rand.Next(100,1000);
// System.Console.WriteLine(number);

// System.Console.WriteLine($"{number/100} {(number-((number/100)*100))-(((number-((number/100)*100))/10)*10)}");

//=================================================================================================================================
// Ввод 2 чисел. Проверять кратно ли второе чило первому

Console.Write("Введите первое число: "); int numFist = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: "); int numSecond = Convert.ToInt32(Console.ReadLine());
if (numFist%numSecond==0){Console.WriteLine($"Число:{numSecond} кратно числу:{numFist}");}
else {Console.WriteLine($"Число:{numSecond} некратно числу:{numFist}");}
