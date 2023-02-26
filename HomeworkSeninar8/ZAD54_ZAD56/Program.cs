//Выполнил: Артем Анатольевич Авдеев (know as Survivor of the SAO & Master of the Geass)
//___________________________________________________________________________________________________________________________________
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//===================================================================================================================================
//Решение:
//-----------------------------------------------------------------------------------------------------------------------------------
int GetDigitString(string txt)    // метод преобразует строку в число, при этом выводит задаваемый комментарий на консоль
{
    System.Console.Write(txt);  //вывод комментария на консоль
    return Convert.ToInt32(Console.ReadLine()); //вызов метода преобразования строки/целое число
}
//-----------------------------------------------------------------------------------------------------------------------------------
void Display2DArray(int[,] myArray)  //метод выводящий содержимое массива в сторку
{
    System.Console.WriteLine();

    for (int i = 0; i < myArray.GetLength(0); i++) //GetLength(0)-метод, возращающий длину массива в первом("0") пространстве("i")
    {
        for (int j = 0; j < myArray.GetLength(1); j++)    //GetLength(1)-метод,возращающий длину массива во втором("1")пространстве("j")
        {
            System.Console.Write(myArray[i, j] + "\t"); //использование табуляции для выравнивания вывода -("\t")
        }

        System.Console.WriteLine(); //пустая строка позволяет вывести построчно 
    }
}
//-----------------------------------------------------------------------------------------------------------------------------------
int[,] GnrtRndVlsFilling2DArray(int i_sizeArray, int j_sizeArray, int lowRND, int hightRND)    //метод создания массива c с ранд.знач.
{
    var varArray = new int[i_sizeArray, j_sizeArray];   //создание массива заданной длины
    var randomValue = new Random(); //объявление рандомной переменной

    for (int i = 0; i < varArray.GetLength(0); i++) //GetLength(0)-метод, возращающий длину массива в первом("0") пространстве("i")
    {
        for (int j = 0; j < varArray.GetLength(1); j++)    //GetLength(1)-метод,возращающий длину массива во втором("1")пространстве("j")
        {
            varArray[i, j] = randomValue.Next(lowRND, hightRND + 1); //внимани 2-не входит в границу правого диапазона (n-1)
        }
    }
    return varArray;
}
//-----------------------------------------------------------------------------------------------------------------------------------
int[,] RangerRowElements(int[,] srcArray)   //метод ранжирования значений в строке
{

    for (int m = 0; m < srcArray.GetLength(0); m++)
    {
        var tempArray = new int[srcArray.GetLength(1)];

        for (int n = 0; n < srcArray.GetLength(1); n++)
        {
            tempArray[n] = srcArray[m, n];
        }

        Array.Sort(tempArray);
        Array.Reverse(tempArray);

        for (int n = 0; n < srcArray.GetLength(1); n++)
        {
            srcArray[m, n] = tempArray[n];
        }
    }
    return srcArray;
}
//-----------------------------------------------------------------------------------------------------------------------------------
string RowWithMinSum(int[,] ourArray)   //метод нахождения строки с наименьшей суммой
{
    string resultString = "";
    var tempArray = new int[ourArray.GetLength(0)];

    for (int m = 0; m < ourArray.GetLength(0); m++)
    {
        for (int n = 0; n < ourArray.GetLength(1); n++)
        {
            tempArray[m] += ourArray[m, n];
        }
    }
    int minSum = tempArray.Min();
    int indexMinSum = Array.IndexOf(tempArray, minSum) + 1;


    return resultString = "В строке №" + indexMinSum + ", минимальное значение суммы элементов в массиве и равно = " + minSum;
}
//-----------------------------------------------------------------------------------------------------------------------------------
void DisplayAll()
{
    var x = GnrtRndVlsFilling2DArray(GetDigitString("Введите кол-во строк: "), GetDigitString("Введите кол-во столбцов: "), 0, 9);
    Display2DArray(x);
    Display2DArray(RangerRowElements(x));//вывод результата решения задачи№54:упорядочить по убыванию элементы каждой строки 2Dмассива

    System.Console.WriteLine();
    System.Console.WriteLine(RowWithMinSum(x));
    System.Console.WriteLine();
}
//-----------------------------------------------------------------------------------------------------------------------------------

DisplayAll();
