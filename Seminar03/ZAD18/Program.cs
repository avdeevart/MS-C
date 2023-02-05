// По заданному номеру четверти, показать диапазон возможных координат 
//_____________________________________________________________________________________________________________________________
void RangeDefinition (int numQuarter)   //объявление метода по выводу диапазона
{
    switch(numQuarter)
    {
        case <1:
        case >4:
            System.Console.WriteLine($"Четверти нумеруютя от 1 до 4, а Вы ввели: {numQuarter}");
            break;
        case 1:
            System.Console.WriteLine($"Четверть - {numQuarter}, диапазон X>0; Y>0");
            break;
        case 2:
            System.Console.WriteLine($"Четверть - {numQuarter}, диапазон X<0; Y>0");
            break;
        case 3:
            System.Console.WriteLine($"Четверть - {numQuarter}, диапазон X>0; Y<0");
            break;
        case 4:
            System.Console.WriteLine($"Четверть - {numQuarter}, диапазон X<0; Y<0");
            break;
    }
}
//_____________________________________________________________________________________________________________________________
int InputCord(string str)   // объявление метода ввода четверти
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
//_____________________________________________________________________________________________________________________________

RangeDefinition(InputCord("Введите номер четверти (от 1 до 4):"));
