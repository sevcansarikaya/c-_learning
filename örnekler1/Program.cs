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


// int baslangic,bitis,artis;
// Console.Write("başlanıç değerini giriniz:");
// baslangic=Convert.ToInt32(Console.ReadLine());
// Console.Write("bitiş değerini giriniz:");
// bitis=Convert.ToInt32(Console.ReadLine());
// Console.Write("artış değerini giriniz:");
// artis=Convert.ToInt32(Console.ReadLine());


//   for(int i=baslangic;i<=bitis;i+=artis)
//             {
//                 Console.WriteLine(i);
//           }

//8.10 elemanlı diziye değer girme ve dizi içindeki değerlerleri For
// Döngüsü kullanarak yazdırma

//  int[] eleman=new int [10];
// eleman[0]=13;

//  for (int i = 0; i < eleman.Length; i++)
//  {
//     Console.WriteLine(eleman[i]);
//  }

// 9. C# 1 – 1.000.000 Arasındaki Asal Sayıları Listeleme

// int kontrol = 0, sayac = 0;
// for (int i = 2; i <= 1000000; i++)
// {
//     kontrol = 0;
//     for (int j = 2; j <= i / 2; j++)
//     {
//         if (i % j == 0)
//         {
//             kontrol++;
//             break;
//         }
//     }
//     if (kontrol == 0)
//     {
//         sayac++;
//         Console.Write(i + "-");
//     }
// }
// Console.WriteLine();
// Console.WriteLine("{0} adet asal sayı bulundu.", sayac);




