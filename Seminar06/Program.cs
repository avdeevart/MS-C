//by Survivor of the SAO
//___________________________________________________________________________________________________________________________________
//Задача 39: перевернуть массив (певая ячека станет последне и т.д.)
//===================================================================================================================================
//-----------------------------------------------------------------------------------------------------------------------------------
int GetDigitString(string txt)    // метод преобразует строку в число, при этом выводит задаваемый комментарий на консоль
{
    System.Console.Write(txt);  //вывод комментария на консоль
    return Convert.ToInt32(Console.ReadLine()); //вызов метода преобразования строки/целое число
}
//-----------------------------------------------------------------------------------------------------------------------------------
int[] GeneratingRandomValuesFillingArray(int sizeArray, int lowRND, int hightRND)    //объединяющий метод - создания массива по условию задачи
{
    var varArray = new int[sizeArray];   //создание массива заданной длины
    var randomValue = new Random(); //объявление рандомной переменной

    for (int i = 0; i < varArray.Length; i++)            //заполнение массива случайными значениями
    {
        varArray[i] = randomValue.Next(lowRND, hightRND + 1); //вниманиt!: значение правого диапазона невходит, поэтому:(n+1)
    }
    return varArray;
}
//-----------------------------------------------------------------------------------------------------------------------------------
int[] InvertedArray(int[] sourceArray)   //метод возращающий перевернутый массив
{
    var invetArray = new int[sourceArray.Length];  // создаем массив, по размеру и структуре одинаковый с исходным

    for (int j = 0; j < sourceArray.Length; j++) //присвоение значений возращаемому массиву, в соответствии с условиями задачи
    {
        invetArray[j] = sourceArray[(sourceArray.Length - 1) - j];
    }

    return invetArray;
}
//-----------------------------------------------------------------------------------------------------------------------------------
void DisplayArray(int[] myArray)  //метод выводящий содержимое массива в сторку
{
    System.Console.WriteLine($"[{string.Join(";", myArray)}]"); //крутой метод вывода массива. параметр1-сепаратор, пар2-сам массив
}
//-----------------------------------------------------------------------------------------------------------------------------------
void DisplayAll()   //демонстрация всех условий и значений
{
    var workArray = GeneratingRandomValuesFillingArray(GetDigitString("Введите размер массива: "), GetDigitString("левая граница: "), GetDigitString("правая граница: "));
    DisplayArray(workArray);
    Console.WriteLine("Перевернутый массив: ");
    DisplayArray(InvertedArray(workArray));
    Console.WriteLine("А это с использованием метода Array.Reverse ");
    Array.Reverse(workArray); //Встроенный метод C# для переворачивания массива, причем данные сохраняет в томже массиве
    DisplayArray(workArray);
}
//-----------------------------------------------------------------------------------------------------------------------------------
DisplayAll();   //по сути - запуск проги