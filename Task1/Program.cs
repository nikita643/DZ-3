/Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Clear();
string AddString(string ver)
{
    
    Console.Write($"ВВедите пятизначное число: ");
    ver = Console.ReadLine();
    return ver;
   
}
void PalindFind(string str)
{
    if (str.Length == 5)
    {
        if(str[0] == str[4] & str[1] == str[3])
        {
            Console.WriteLine($"Число {str} является полиндромом!");
        }
        else{Console.WriteLine($"Число {str} не является полиндромом!");}
    }
    
    else{Console.WriteLine($"Число {str} не является пятизначным!");}
    
}
string palind = string.Empty;
palind = AddString(palind);
PalindFind(palind);