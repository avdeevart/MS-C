//by Survivor of the SAO & Master of the GEASS
//___________________________________________________________________________________________________________________________________
// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.
// Задача 55: Задайте двумерный массив. И транспонируйте его
//===================================================================================================================================
// Решение:

//-----------------------------------------------------------------------------------------------------------------------------------
int GetDigitString(string txt)    // метод преобразует строку в число, при этом выводит задаваемый комментарий на консоль
{
    System.Console.Write(txt);  //вывод комментария на консоль
    return Convert.ToInt32(Console.ReadLine()); //вызов метода преобразования строки/целое число
}
//-----------------------------------------------------------------------------------------------------------------------------------
int[,] GnrtRndVlsFilling2DArray(int i_sizeArray, int j_sizeArray, int lowRND, int hightRND)    //метод создания массива по условию задачи
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
int[,] ExchengeElement2DArray(int[,] workArray, int trgRow, int trgCol, int srcRow, int srcCol)  //метод меняющий местами один элемент 2D-массива на другой
{
    int tempElement = workArray[trgRow, trgCol];
    workArray[trgRow, trgCol] = workArray[srcRow, srcCol];
    workArray[srcRow, srcCol] = tempElement;
    return workArray;
}
//-----------------------------------------------------------------------------------------------------------------------------------
int[,] FistRowEXCEndRow2DArray(int[,] targetArray)   //метод, меняющий местами первую строку с последней строкой 2D массива
{
    for (int i = 0; i < targetArray.GetLength(1); i++)
    {
        targetArray = ExchengeElement2DArray(targetArray, 0, i, targetArray.GetLength(0) - 1, i);//вызов метода обмена
    }
    return targetArray;
}
//-----------------------------------------------------------------------------------------------------------------------------------
int[,] TransponitionArray(int[,] victimArray)  //транспонирование массива
{
    int[,] resultArray = new int[victimArray.GetLength(1), victimArray.GetLength(0)];
    for(int m=0; m<victimArray.GetLength(0);m++)
    {
        for(int n=0; n<victimArray.GetLength(1);n++)
        {
            resultArray[n,m]=victimArray[m,n];
        }
    }
    return resultArray;
}
//-----------------------------------------------------------------------------------------------------------------------------------
void DisplayAll()
{
    int[,] operationArray = GnrtRndVlsFilling2DArray(GetDigitString("Кол-во строк: "), GetDigitString("Кол-во столбцов: "), 0, 99);
    Display2DArray(operationArray);
    operationArray = FistRowEXCEndRow2DArray(operationArray);   //выполнение условий задачи№53
    System.Console.WriteLine();
    System.Console.WriteLine("Обмен певой строки на последнюю:");
    Display2DArray(operationArray);
    
    System.Console.WriteLine();
    System.Console.WriteLine("Транспонирование массива:");
    Display2DArray(TransponitionArray(operationArray)); //выполнение условий задачи№55
}
//-----------------------------------------------------------------------------------------------------------------------------------

DisplayAll();
