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
    metka:
    switch (index10HP)
    {
        case <1: index10HP=index10HP+10;goto metka;break;
        case >10: index10HP=index10HP-10;goto metka;break;

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
    metka2:
    switch (index12EB)
    {
        case <1: index12EB=index12EB+12;goto metka2;break;
        case >12:index12EB=index12EB-12;goto metka2;break;

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

//------------------------------------------------------------------------------------------------------------------------------------
bool trueOddFalseEven(int number)   //Истина - если число нечетное, ложь - если четное. Нужно для проверки согласованности НС и ЗВ
{
    if ((number%2)==0){return false;} else{return true;}
}
//------------------------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------------------------
string FullNameHPEB(int nameHP, int nameEB) // Слияние названия НС с ЗВ - полное имя божества (с проверкой на совместимость инь/ЯН)
{
    if(trueOddFalseEven(nameHP))
    {
        if(trueOddFalseEven(nameEB))
        {return (name10HeavenPillars(nameHP)+" "+name12EarthBranches(nameEB));}
        else{return "Ошибка!: Недопустимое слияние";}
    }
    else
    {
        if(trueOddFalseEven(nameEB)){return "Ошибка!: Недопустимое слияние";}
        else{return (name10HeavenPillars(nameHP)+" "+name12EarthBranches(nameEB));}
    }
}
//------------------------------------------------------------------------------------------------------------------------------------


// System.Console.WriteLine($"Имя Небесного Столпа: {name10HeavenPillars(GetDigit("Введите номер Небесного Столпа: "))}");
// System.Console.WriteLine($"Имя Земной Ветви: {name12EarthBranches(GetDigit("Введите номер Земной Ветви: "))}");

System.Console.WriteLine($"Полное имя: {FullNameHPEB(GetDigit("Введите номер Небесного Столпа: "),GetDigit("Введите номер Земной Ветви: "))}");

