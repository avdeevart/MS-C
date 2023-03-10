//Выполнил: Артем Анатольевич Авдеев (know as Survivor of the SAO & Master of Code Geass)
//___________________________________________________________________________________________________________________________________
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//====================================================================================================================================
//Решение:
//-----------------------------------------------------------------------------------------------------------------------------------
double RenderX(double b1, double k1, double b2, double k2)   //расчет значения Х
{
    double x=((b2-b1)/(k1-k2));
    return x;
}
//-----------------------------------------------------------------------------------------------------------------------------------
double RenderY(double x, double b1, double k1)    //расчет значения Y
{
    double y=k1*x+b1;
    return y;
}
//--------------------------------------------------------------------------------------------------------------------------
int GetDigitString(string txt)    // метод преобразует строку в число, при этом выводит задаваемый комментарий на консоль
{
System.Console.Write(txt);  //вывод комментария на консоль
return Convert.ToInt32(Console.ReadLine()); //вызов метода преобразования строки/целое число
}
//-----------------------------------------------------------------------------------------------------------------------------------
void ResultXY() //ввод данных и вывод результата
{
    double inpB1=GetDigitString("Введите В1 = ");
    double inpK1=GetDigitString("Введите K1 = ");
    double inpB2=GetDigitString("Введите В2 = ");
    double inpK2=GetDigitString("Введите K2 = ");

    Console.WriteLine($"Ответ: ({Math.Round(RenderX(inpB1,inpK1,inpB2,inpK2),1)};{Math.Round(RenderY(RenderX(inpB1,inpK1,inpB2,inpK2),inpB1,inpK1),1)})"); 
}
//-----------------------------------------------------------------------------------------------------------------------------------
//Поехали!

ResultXY();