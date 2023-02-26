//Выполнил: Артем Анатольевич Авдеев (know as Survivor of the SAO & Master of the Geass)
//___________________________________________________________________________________________________________________________________
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
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
int[,] GnrtRNDSecondArrayByCondition(int[,] fistArray)  //генерация вторичного массива, где кол-во строк, равно кол-ву столбцов исходной матрицы
{
    int[,] secondArray = GnrtRndVlsFilling2DArray(fistArray.GetLength(1), fistArray.GetLength(0), 0, 9);
    return secondArray;
}
//-----------------------------------------------------------------------------------------------------------------------------------
int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)    //метод произведения двух матриц в соответствии с правилами
{
    var resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }

    return resultMatrix;
}
//-----------------------------------------------------------------------------------------------------------------------------------
void DisplayAll()
{
    var a = GnrtRndVlsFilling2DArray(GetDigitString("Задайте количество строк:"), GetDigitString("Задайте количество колонок:"), 0, 9);
    
    System.Console.WriteLine();
    System.Console.WriteLine("Результат генерации исходной матрицы:");
    Display2DArray(a);

    System.Console.WriteLine();
    System.Console.WriteLine("Производная матрица для произведения, в соответствии с требованиями и с рандомными числами:");
    var b = GnrtRNDSecondArrayByCondition(a);
    Display2DArray(b);
    
    System.Console.WriteLine();
    System.Console.WriteLine("Результат произведения двух матриц:");
    Display2DArray(MatrixMultiplication(a,b));
}
//-----------------------------------------------------------------------------------------------------------------------------------

DisplayAll();
