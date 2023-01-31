// Вывод случайного числа из отрезка [10,99] и покзывает наибольшую цифру числа

// int number = new Random().Next(10,100); //класс рандомных чисел в next - 
                                        // указывает диапазон. причем крайнее число не включается, поэтому +1

Random rand = new Random();
int number = rand.Next(10,100);
System.Console.WriteLine(number);

// int leftnum = number/10;
// int rightnum= number%10;

System.Console.WriteLine($"{number/10} {number%10}");

if (number/10>number%10) {System.Console.WriteLine($"{number/10}>{number%10}");}
    
    else if (number/10<number%10) {System.Console.WriteLine($"{number/10}<{number%10}");}
            
            else {System.Console.WriteLine($"{number/10}<{number%10}");}
