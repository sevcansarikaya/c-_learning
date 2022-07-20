//1. Ekranda 10 kez Merhaba Dünya yazdıran C# Programı
//  for (int i = 0; i <= 10; i++)
//  {
//     Console.WriteLine(i+"merhaba dünya");
//  }

//2. Kullanıcının girdiği metni 10 kez alt alta yazdıran Console programı

// string metin;
// Console.WriteLine("metni giriniz:");
// metin = Console.ReadLine()!;
// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine(metin);
// }
//3. Kullanıcının girdiği 10 sayıdan 50 den küçük olanların adetini 
//bulan ve gösteren Console

// int sayi, adet = 0;

// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine("sayı giriniz:");
//     sayi = Convert.ToInt32(Console.ReadLine()); 
//     if (sayi < 50)
//     {
//         adet++;
//     }
// }

// Console.WriteLine("50 den küçük sayılar:" + adet);

// int sayi1, adet1 = 0;
// for (int i = 1; i <= 10; i++)
// {
//     Console.Write(i + ".sayıyı Girin : ");
//     sayi1 = Int32.Parse(Console.ReadLine());
//     if (sayi1 < 50)
//     {
//         adet1++;
//     }
// }
// Console.WriteLine("50 den küçük girilen sayı adeti : " + adet1);



// string ch = Console.ReadLine()!;

// Console.WriteLine(status(ch));

// switch (ch)
// {
//     case "aa":
//         Console.WriteLine("a ya bastın");
//         break;
//     case "bb":
//         Console.WriteLine("b ye bastın");
//         break;
//     default:
//         Console.WriteLine("başka bir tuşa bastın");
//         break;
// }




// // Expression body
// string status(string s) => s switch
// {
//     "aa" => "geçtin".ToUpper(),
//     "bb" => "geçtin ama yetersiz".ToUpper(),
//     "cc" => "yetersiz".ToUpper(),
//     "dd" => "kaldın".ToUpper(),
//     _ => "sevcan".ToUpper()
// };

//4.Kullanıcının girdiği 5 sayıdan 50′ den büyük olanların toplamını
// gösteren Console programı

// int sayi, sonuc=0;

// for (int i = 1; i <=5; i++)
// {
//     Console.Write(i+".sayı giriniz:");
//     sayi = Convert.ToInt32(Console.ReadLine()); 
//     if (sayi > 50)
//     {
//        sonuc+=sayi;
//     }
// }
//   Console.WriteLine("sonuç:"+sonuc); 

//5.Bilgisayarın rastgele tuttuğu 10 sayıdan çift ve tek olanların sayısını
// gösteren Console Örneği:

// int sayi, tekAdet = 0, ciftAdet = 0;
//   Random rnd = new Random();
// for (int i = 1; i <= 10; i++)
// {

//     sayi = rnd.Next(1, 100);
//     Console.WriteLine(sayi);
//     if (sayi % 2 == 0)
//     {
//         ciftAdet++;
//     }
//     else
//     {
//         tekAdet++;
//     }
// }
// Console.WriteLine("Çift Sayı Adeti : "+ ciftAdet);
// Console.WriteLine("Tek Sayı Adeti : "+tekAdet);


//6. Bilgisayar tarafından rastgele tutulan 10 sayıdan 50′ den yukarı
// olanların ortalamasını bulan Console programı

// int adet = 0, toplam = 0;
// Random rstg = new Random();

// for (int i = 1; i <= 10; i++)
// {
// int sayi=rstg.Next(1,100);
// Console.WriteLine(sayi);
// if (sayi>50)
// {
//   adet++;
//   toplam+=sayi;
// }
// }
// Console.WriteLine("ort:{0}",(toplam/adet));

// 7. Kullanıcıdan başlangıç,bitiş ve artım değeri istenerek, 
//  verilen artış miktarına göre başlangıç ve bitiş sayıları arasındaki 
//  sayıları ekranda gösteren programı