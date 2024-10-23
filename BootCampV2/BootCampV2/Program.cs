
int day = 5;

string dayName = day switch
{
    1 => "Pazartesi",
    2 => "Salı",         //.NET CORE 8 ile geldi
    3 => "Çarşamba",
    _=>"Geçersiz Gün"
};
//--------------------------------------------
switch(day)
{
    case 1:
        Console.WriteLine("");
            break;
}

object obj = "Merhaba";
string result = obj switch
{
    int sayi => "Bu bir tam sayi",
    string metin => "Bu bir string",
    null => "Boş bir değer",
    _ => "Bilinmiyor"
};