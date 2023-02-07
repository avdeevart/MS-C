//Методы вывода 10НС и 12ЗВ БаЦзы по номерам by Survivor of the SAO

//------------------------------------------------------------------------------------------------------------------------------------
int GetDigit(string txt)    // метод берет и выводит стоку(с комментарием), затем возращает целое число с консоли
{
System.Console.Write(txt);
return Convert.ToInt32(Console.ReadLine());
}
//------------------------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------------------------
string name10HeavenPillars(int index10HP)    //метод вывода названия 10 Небесных Столпов по введеному номеру
{
    switch (index10HP)
    {
        case <1: return "!ОШИБКА!: меньше-1";break;
        case >10: return "!ОШИБКА!: больше-10";break;

        case 1: return "ЯД";break;
        case 2: return "ид";break;
        case 3: return "ЯО";break;
        case 4: return "ио";break;
        case 5: return "ЯЗ";break;
        case 6: return "из";break;           
        case 7: return "ЯМ";break;                
        case 8: return "им";break;                
        case 9: return "ЯВ";break;                
        case 10: return "ив";break;                
    }
}
//------------------------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------------------------
string name12EarthBranches(int index12EB)    //метод вывода названия 12 Земных Ветвей по введеному номеру
{
    switch (index12EB)
    {
        case <1: return "!ОШИБКА!: меньше-1";break;
        case >12: return "!ОШИБКА!: больше-12";break;

        case 1: return "Тигр";break;
        case 2: return "Кролик";break;
        case 3: return "Дракон";break;
        case 4: return "Змея";break;
        case 5: return "Лошадь";break;
        case 6: return "Коза";break;           
        case 7: return "Обезьяна";break;                
        case 8: return "Петух";break;                
        case 9: return "Собака";break;                
        case 10: return "Свинья";break;
        case 11: return "Крыса";break;                
        case 12: return "Бык";break;                
                
    }
}
//------------------------------------------------------------------------------------------------------------------------------------


System.Console.WriteLine($"Имя Небесного Столпа: {name10HeavenPillars(GetDigit("Введите номер Небесного Столпа: "))}");
System.Console.WriteLine($"Имя Земной Ветви: {name12EarthBranches(GetDigit("Введите номер Земной Ветви: "))}");