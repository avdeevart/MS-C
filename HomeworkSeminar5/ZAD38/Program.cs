//Выполнил: Артем Анатольевич Авдеев (know as Survivor of the SAO)
//___________________________________________________________________________________________________________________________________
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
//===================================================================================================================================
// Решение:
int GetDigitString(string txt)    // метод преобразует строку в число, при этом выводит задаваемый комментарий на консоль
{
System.Console.Write(txt);  //вывод комментария на консоль
return Convert.ToInt32(Console.ReadLine()); //вызов метода преобразования строки/целое число
}
//-----------------------------------------------------------------------------------------------------------------------------------
double [] GeneratingRandomValuesFillingArray(int sizeArray,int lowRND,int hightRND)    //объединяющий метод - создания массива по условию задачи
{
    var varArray = new double [sizeArray];   //создание массива заданной длины
    var randomValue = new Random(); //объявление рандомной переменной

    for (int i=0; i<varArray.Length; i++)            //заполнение массива случайными значениями
        {
            varArray[i]=(randomValue.Next(lowRND,hightRND+1)+Math.Round(randomValue.NextDouble(),1)); //вниманиt!: значение правого диапазона невходит, поэтому:(n+1)
        }
    return varArray;
}
//-----------------------------------------------------------------------------------------------------------------------------------
void MinAndMaxValueByArray(double [] sourceArray, out double minValue, out double maxValue, out double diffMaxMin)  //метод по условию задачи
{
    maxValue=sourceArray[0];
    minValue=sourceArray[0];
    for(int i=0; i<sourceArray.Length;i++)
    {
        if(sourceArray[i]>maxValue){maxValue=sourceArray[i];}
        else{if(sourceArray[i]<minValue){minValue=sourceArray[i];}}
    }
    diffMaxMin=Math.Round(maxValue-minValue,1);
}

//-----------------------------------------------------------------------------------------------------------------------------------
void DisplayArray (double [] myArray)  //метод выводящий содержимое массива в сторку
{
    System.Console.WriteLine($"[ {string.Join("; ",myArray)} ]"); //крутой метод вывода массива. параметр1-сепаратор, пар2-сам массив
}
//-----------------------------------------------------------------------------------------------------------------------------------
void DisplayAll()   //демонстрация всех условий и значений
{
    double [] tempArray=GeneratingRandomValuesFillingArray(GetDigitString("Введите длину массива: "),0,100);
    
        System.Console.WriteLine("");
    DisplayArray(tempArray);
        System.Console.WriteLine("");
    MinAndMaxValueByArray(tempArray, out double minValue, out double maxValue, out double diffMaxMin);
    System.Console.WriteLine($"Максимальный элемент массива: {maxValue}; Минимальный элемент массива:{minValue} Разница: {diffMaxMin}");
}
//-----------------------------------------------------------------------------------------------------------------------------------

DisplayAll();   //по сути - запуск проги