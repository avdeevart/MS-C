// Принимаем на входе координаты двух точек, на выходе находим расстояние между ними в 2D-пространстве

//_____________________________________________________________________________________________________________________________

int InCord(string txt)   // объявление метода ввода данных для определения координаткоординат
{
    System.Console.Write(txt);
    return Convert.ToInt32(Console.ReadLine());
}
//_____________________________________________________________________________________________________________________________

double PointsDistance2D(int ax, int ay, int bx, int by) //объявление метода, возращающего расстояние между точками
{
    double ResultDistance=Math.Sqrt(Math.Pow(bx-ax,2)+Math.Pow(by-ay,2));
    return ResultDistance;
}
//_____________________________________________________________________________________________________________________________

int xa=InCord("Веедите координту Х для точки А:");
int ya=InCord("Веедите координту Y для точки А:");
int xb=InCord("Веедите координту Х для точки B:");
int yb=InCord("Веедите координту Y для точки B:");

System.Console.WriteLine($"Расстояние между точками A({xa};{ya}) и B({xb};{yb}) в 2D составляет : {Math.Round(PointsDistance2D(xa,ya,xb,yb),3)}");