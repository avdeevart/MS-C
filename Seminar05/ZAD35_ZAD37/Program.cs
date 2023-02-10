//by Survivor of the SAO

//Задать массив из N элементов, заполненный случайными числами [-9,9]. Найти сумму отрицатильных и положительных элементов

//--------------------------------------------------------------------------------------------------------------------------
int GetDigitFromString(string txt)    // метод преобразует строку в число, при этом выводит задаваемый комментарий на консоль
{
System.Console.Write(txt);  //вывод комментария на консоль
return Convert.ToInt32(Console.ReadLine()); //вызов метода преобразования строки/целое число
}
//-----------------------------------------------------------------------------------------------------------------------------------
int [] CreateAnArrayOfGivenLength (int num) //метод создания массива нужной длины (из целого числа)
{
    var variableLengthArray = new int [num];    //объявление массива и определение его длины
    return variableLengthArray;
}
//-----------------------------------------------------------------------------------------------------------------------------------
int [] GeneratingRandomValuesFillingArray(int sizeArray,int lowRND,int hightRND)    //объединяющий метод - создания массива по условию задачи
{
    var varArray = CreateAnArrayOfGivenLength(sizeArray);   //создание массива заданной длины
    var randomValue = new Random(); //объявление рандомной переменной

    for (int i=0; i<varArray.Length; i++)            //заполнение массива случайными значениями
        {
            varArray[i]=randomValue.Next(lowRND,hightRND+1); //внимани 2-не входит в границу правого диапазона (n-1)
        }
    return varArray;
}
//-----------------------------------------------------------------------------------------------------------------------------------
void DisplayArray (int [] myArray)  //метод выводящий содержимое сгенерированного массива
{
    System.Console.WriteLine($"Массив:[{string.Join(";",myArray)}]"); //крутой метод вывода массива. параметр1-сепаратор, пар2-сам массив
}
//-----------------------------------------------------------------------------------------------------------------------------------
int PositiveSum(int [] arrayX)   //возращает сумму положительных чисел
{
    int positiveSum=0;
    for(int i=0; i<arrayX.Length; i++)
    {
        if (arrayX[i]>=0){positiveSum=positiveSum+arrayX[i];}
    }
    return positiveSum;
}
//-----------------------------------------------------------------------------------------------------------------------------------
int NegativeSum(int [] arrayY)   //возращает сумму отрицательных чисел
{
    int negativeSum=0;
    for(int j=0; j<arrayY.Length; j++)
    {
        if (arrayY[j]<0){negativeSum=negativeSum+arrayY[j];}
    }
    return negativeSum;
}
//-----------------------------------------------------------------------------------------------------------------------------------
void SumNegativeAndPositive(int [] arrayALT, out int sumNegativeALT, out int sumPositiveALT)// тоже самое, но через OUT 
// (можно также через массив). Причем обратить внимание, как запускается этот метод (см.ниже)
{
    sumNegativeALT=0;
    sumPositiveALT=0;
    for(int k=0; k<arrayALT.Length;k++)
    {
        switch(arrayALT[k])
        {
            case <0: sumNegativeALT+=arrayALT[k];break;
            case >=0: sumPositiveALT+=arrayALT[k];break;
        }
    }
}
//-----------------------------------------------------------------------------------------------------------------------------------
int [] InvertVolumesArray(int [] OriginalArray)   //замена положительных элементов на отрицательные и наоборот
{
    for (int p=0; p<OriginalArray.Length;p++)
    {
        OriginalArray[p]=OriginalArray[p]*(-1);
    }
    return OriginalArray;
}
//-----------------------------------------------------------------------------------------------------------------------------------
string SeachNumberOfArray(int findNum, int [] baseArray) //поиск числа в массиве, в т.ч. выводит сколько раз встречается
{
    int indexFindNum=0;
    for(int t=0; t<baseArray.Length;t++)
    {
        if (baseArray[t]==findNum){indexFindNum++;} 
    }
    if (indexFindNum>0){return "Число: "+findNum+" встречается в массиве "+indexFindNum+ " раз";}
    else{return "Число: "+findNum+" отсутствует в этом массиве";}
}
//-----------------------------------------------------------------------------------------------------------------------------------
int CountNumbersFromDiapason(int [] DownArray, int leftFind, int rightFind)  //количество элементов в задаваемом диапазоне
{
    int countNumbers=0;

    for(int q=0; q<DownArray.Length;q++)
    {
        if(DownArray[q]>=leftFind && DownArray[q]<=rightFind){countNumbers++;}
    }
    return countNumbers;
}
//-----------------------------------------------------------------------------------------------------------------------------------
int [] multiplicationPairArray(int [] newArray)   //возращение массива из другого массива с вычеслением произведения: 1*последний; 2*предпоследний ....
{
    int [] PairSum= new int [newArray.Length/2];
    for(int w=0; w<newArray.Length/2;w++)
    {
        PairSum[w]=newArray[w]*newArray[(newArray.Length-1)-w];
    }
    return PairSum;

}
//-----------------------------------------------------------------------------------------------------------------------------------
void DisplayAll()   //демонстрация всех условий и значений
{
    int [] thisArray=GeneratingRandomValuesFillingArray(GetDigitFromString("Введите длину массива:"),GetDigitFromString("Введите нижний уровень:"),GetDigitFromString("Введите верхний уровень:"));
 
    DisplayArray(thisArray);
 
    System.Console.WriteLine($"Сумма положительных значений: {PositiveSum(thisArray)}; Сумма отрицательных значений: {NegativeSum(thisArray)}");
 
    SumNegativeAndPositive(thisArray,out int sumNegativeALT, out int sumPositiveALT);   //Обратить внимание, как запускается метод!!!
    //в данном случае имена out-переменнных внутри метода и объявленные переменные за его пределами, должны быть одними и теми-же !!!
   
    System.Console.WriteLine($"Сумма положительных значений(через out): {sumPositiveALT}; Сумма отрицательных значений(через out): {sumNegativeALT}");
  
    DisplayArray(InvertVolumesArray(thisArray));
   
    System.Console.WriteLine(SeachNumberOfArray(GetDigitFromString("Введите число для поиска: "),thisArray));

    System.Console.WriteLine($"Количество элементов в диапазоне: {CountNumbersFromDiapason(thisArray,GetDigitFromString("Введите левую границу поиска: "),GetDigitFromString("Введите правую границу поиска: "))}");

    DisplayArray(multiplicationPairArray(thisArray));

}
//-----------------------------------------------------------------------------------------------------------------------------------

DisplayAll();
