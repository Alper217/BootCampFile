//Çalışanlar listesi olucak çaluşanın adı soyadı yaşı bölümü
//Kullanıcı sadece yazılım bölümünde çalışanları getirmeli



//using GeneralRepeat.Models;

//using System;

//List<Person> person = new List<Person>
//{
//    new Person {Name = "Ali", SurName = "Demir", Age = 55, Department = "Yazılım"},
//    new Person {Name = "Veli", SurName = "Demir", Age = 55, Department = "IT"},
//    new Person {Name = "Hüseyin", SurName = "Demir", Age = 55, Department = "BT"},
//    new Person {Name = "Hasan", SurName = "Demir", Age = 55, Department = "Sales"},
//    new Person {Name = "Berkay", SurName = "Demir", Age = 55, Department = "Yazılım"},
//};

//Console.

//
// Haftaya pazartesiye kadar bir banka sistemi
//Bakiye listeleme
//Para gönderme
//Para çekme
//Para yatırma
//Bir dekont maili gönderme

//Kullanıcıdan 5 tane sayı alınız ve alınan sayıları 1-100 arasında mı kontrol et?

int[] nums = new int[5];
Console.WriteLine("Please, Enter the different five number!");
for (int i = 0; i < 5; i++)
{
    nums[i] = int.Parse(s: Console.ReadLine());
}
foreach (int number in nums)
{
    if (number < 0 || number > 100)
    {
        Console.WriteLine("The requested number is not OK");
    }
    else
    {
        Console.WriteLine("Pass!");
    }
}


//kullanıcıdan üç basamaklı sayı alınacak ve bu sayının yüzler onlar birler basamağı alınıp gösterilmeli
//int number;
//do
//{
//    Console.WriteLine("Please enter three digit number!");
//}
//while (!int.TryParse(Console.ReadLine(), out number) || number < 100 || number >= 1000 || Convert.ToString(number).StartsWith("0")){

//}
    
//ÖDEV ÖDEV ÖDEV ÖDEV 
//bİR BANKA SİSTEMİ YAPILACAK
//BAKİYE LİSTELE,PARA GÖNDERME,PARA ÇEKME,PARA YATIRMA,BİR DEKONT MAİLİ GÖNDERME
