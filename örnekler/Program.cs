// 1.Kullanıcıdan 5 sayı isteyerek bu sayıların toplamını bulan basit Console programı

// int sayi,sonuc=1;

// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine("{0}.Sayıyı Giriniz;", i);
//  sayi= Convert.ToInt32(Console.ReadLine());
//  sonuc+=sayi;
// }
// Console.WriteLine("sonuc="+sonuc);

//2. Kullanıcıdan 3 sayı isteyerek bu sayıların toplamını, farkını,
// çarpımını ve bölümünü ekranda gösteren basit C# Console uygulaması

// int sayi1,carpim=1,cıkarma=1;

// for (int i = 1; i <= 3; i++)
// {
//    Console.WriteLine("{0}.lütfen sayı giriniz",i); 
//    sayi1=Convert.ToInt32(Console.ReadLine());
//    carpim*=sayi1;
//    cıkarma-=sayi1;
// }
// Console.WriteLine("çarpım="+carpim);
// Console.WriteLine("cıkarma="+cıkarma);

//3.Kullanıcının girdiği sayının %18 ini bulup yazdıran program

// double sayi;

//   Console.WriteLine("sayı giriniz=");
//   sayi=Convert.ToInt32(Console.ReadLine());
//   sayi=sayi*18/100;
//   Console.WriteLine(sayi);

//4. Kullanıcının girdiği sayının yine kullanıcının girdiği % değerini
//hesaplayan ve gösteren program


// double sayi,yuzde, sonuc;
//  Console.WriteLine("bir sayıyı giriniz:");
//  sayi=Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine("bir yüzde giriniz:");
//  yuzde=Convert.ToDouble(Console.ReadLine());
//  sonuc=sayi*yuzde/100;
//  Console.WriteLine("sonuç:"+sonuc);


//5. Alış Fiyatı Girilen malın kullanıcının girdiği yüzdelik karla
// satış fiyatını bulan program

// decimal alisfiyati, satısfiyat;
// int yüzdelikkar;
// alisfiyati = 12M;
// Console.WriteLine("alış fiyatı:" + alisfiyati);
// Console.WriteLine("yüzdelik kar:");
// yüzdelikkar = Convert.ToInt32(Console.ReadLine());

// satısfiyat = alisfiyati + (alisfiyati * yüzdelikkar / 100);
// Console.WriteLine("satış fiyatı" + satısfiyat);


//6. Yarıçapı girilen dairenin alanını ve çevresini bulan program


//  double r,alan,cevre,pi=3.14;

//   Console.WriteLine("yarıçapı giriniz:");
//   r=Convert.ToDouble(Console.ReadLine());
//   alan=r*r*pi;
//   Console.WriteLine("dairenin alanı:"+alan);
//   cevre=2*r*pi;
//   Console.WriteLine("dairein çevresi"+cevre);

//7.3 Yazılı notu girilen öğrencinin ortalamasını ve sınıf geçme durumunu gösteren program

// int not1, not2, not3;
// double ort;
// Console.WriteLine("not1:");
// not1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("not2:");
// not2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("not3:");
// not3 = Convert.ToInt32(Console.ReadLine());
// ort = (not1 + not2 + not3) / 3;
// if (ort < 50)

//     Console.WriteLine($"sınıf ortalamanız={ort},sınıta kaldınız.");
// else
//     Console.WriteLine($"sınıf ortalamanız={ort},sınıfı geçtiniz. tebrikler");


//8. Girilen 2 sayıdan büyük olanını bulan program
// int a, b;

// Console.WriteLine("a sayısını giriniz:");
// a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("b sayısını giriniz:");
// b = Convert.ToInt32(Console.ReadLine());

// if (a > b)
//     Console.WriteLine("a sıyısı b den büyüktür.");
// else if(a==b)
            
//                Console.WriteLine("İki Sayı Eşit");
// else
//     Console.WriteLine("b sayısı a dan büyüktür");

//9. Girilen sayının tek mi çift mi olduğunu bulan program

// int sayi;

// Console.WriteLine("sayıyı giriniz:");
// sayi=Convert.ToInt32(Console.ReadLine());
// if (sayi%2==1)
// {
//     Console.WriteLine("sayı tektir.");
// }
// else
// {
//     Console.WriteLine("sayı çifttir.");
// }


//10. Girilen sayının 4 ve 7 ye tam bölünüp bölünmediğini bulan program

// int sayi;
// Console.WriteLine("sayı giriniz:");
// sayi=Convert.ToInt32(Console.ReadLine());

// if (sayi%4==0 && sayi%7==0)
// {
//     Console.WriteLine("sayı koşula uygundur.");
// }
// else
// Console.WriteLine("sayı koşula uygun değildir.");