// By Survivor of the SAO
//------------------------

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());


if (numberB==numberA*numberA)
{
    Console.WriteLine($"Второе число {numberB} является квадратом первого {numberA}");
}
else {
    Console.WriteLine($"Второе число {numberB} не является квадратом первого {numberA}");
}

// System.Console.WriteLine("Введите номер дня недели:");
// int numday=Convert.ToInt32(Console.ReadLine());


// switch (numday) {
//     case 1:
//         System.Console.WriteLine("Понедельник");
//         break;
    
//     case 2:
//         System.Console.WriteLine("Вторник");
//         break;

//     case 3:
//         System.Console.WriteLine("Среда");
//         break;

//     case 4:
//         System.Console.WriteLine("Четверг");
//         break;

//     case 5:
//         System.Console.WriteLine("Пятница");
//         break;

//     case 6:
//         System.Console.WriteLine("Суббота");
//         break;

//     case 7:
//         System.Console.WriteLine("Воскресенье");
//         break;

//     default: 
//         System.Console.WriteLine("Нет дня недели под таким номером");
//         break;
// }