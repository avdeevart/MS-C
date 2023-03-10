//Выполнил: Артем Анатольевич Авдеев (know as Survivor of the SAO & Master of the Geass)
//___________________________________________________________________________________________________________________________________
//Задача 60: Сформируйте трёхмерный массив из двузначных чисел.Напишите программу, которая будет построчно выводить массив, добавляя
// индексы каждого элемента.
//===================================================================================================================================
//Решение:
//-----------------------------------------------------------------------------------------------------------------------------------
int GDS(string txt)    // метод преобразует строку в число, при этом выводит задаваемый комментарий на консоль
{
    System.Console.Write(txt);  //вывод комментария на консоль
    return Convert.ToInt32(Console.ReadLine()); //вызов метода преобразования строки/целое число
}
//-----------------------------------------------------------------------------------------------------------------------------------
void Display3DArrayIndexToo(int[,,] myArray)  //метод выводящий содержимое массива в сторку
{
    System.Console.WriteLine();

    for (int i = 0; i < myArray.GetLength(0); i++) //GetLength(0)-метод, возращающий длину массива в первом("0") пространстве("i")
    {
        for (int j = 0; j < myArray.GetLength(1); j++)    //GetLength(1)-метод,возращающий длину массива во втором("1")пространстве("j")
        {
            for (int p = 0; p < myArray.GetLength(2); p++)    //GetLength(1)-метод,возращающий длину массива во втором("1")пространстве("j")
            {
                System.Console.Write(myArray[i, j, p] + "[" + i + "," + j + "," + p + "]" + "\t"); //использование табуляции для выравнивания вывода -("\t")
            }
        }

        System.Console.WriteLine(); //пустая строка позволяет вывести построчно 
    }
}
//-----------------------------------------------------------------------------------------------------------------------------------
int[,,] GnrtRndVlsFilling3DArray(int i_sizeArray, int j_sizeArray, int p_sizeArray, int lowRND, int hightRND)    //метод создания массива c с ранд.знач.
{
    var varArray = new int[i_sizeArray, j_sizeArray, p_sizeArray];   //создание массива заданной длины
    var randomValue = new Random(); //объявление рандомной переменной

    for (int i = 0; i < varArray.GetLength(0); i++) //GetLength(0)-метод, возращающий длину массива в первом("0") пространстве("i")
    {
        for (int j = 0; j < varArray.GetLength(1); j++)    //GetLength(1)-метод,возращающий длину массива во втором("1")пространстве("j")
        {
            for (int p = 0; p < varArray.GetLength(2); p++)    //GetLength(1)-метод,возращающий длину массива во втором("2")пространстве("p"
            {
                varArray[i, j, p] = randomValue.Next(lowRND, hightRND + 1); //внимани 2-не входит в границу правого диапазона (n-1)
            }
        }
    }
    return varArray;
}
//-----------------------------------------------------------------------------------------------------------------------------------
void DisplayAll()
{
    Display3DArrayIndexToo(GnrtRndVlsFilling3DArray(GDS("Введите длину массива: "), GDS("Введите высоту массива: "), GDS("Введите глубину массива: "), 10, 99));
}
//-----------------------------------------------------------------------------------------------------------------------------------
DisplayAll();