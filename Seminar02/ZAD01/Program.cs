// Рандомим 3х-значное число и удаляет вторую цифру этого числа //by Survivor of the SAO

Random rand = new Random();
int number = rand.Next(100,1000);
System.Console.WriteLine(number);

System.Console.WriteLine($"{number/100} {(number-((number/100)*100))-(((number-((number/100)*100))/10)*10)}");
