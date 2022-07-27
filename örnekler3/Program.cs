//Kullanıcının girdiği iki sayı ile seçilen işlemi Switch-case kullanarak 
//yapan C# programının kodları:

// Console.WriteLine("Lütfen 1. sayıyı giriniz");
// int sayi1 = Int32.Parse(Console.ReadLine());

// Console.WriteLine("Lütfen 2. sayıyı giriniz");
// int sayi2 = Int32.Parse(Console.ReadLine());

// Console.WriteLine("Lütfen işlem türünü giriniz");
// Console.WriteLine("toplama=1, çıkarma=2, çarpma=3, bölme=4");
// int islem = Int32.Parse(Console.ReadLine());

// switch (islem)
// {
//     case 1: Console.WriteLine(sayi1 + sayi2); break;
//     case 2: Console.WriteLine(sayi1 - sayi2); break;
//     case 3: Console.WriteLine(sayi1 * sayi2); break;
//     case 4: Console.WriteLine(sayi1 / sayi2); break;

//     default: Console.WriteLine("Hata böyle bir işlem bulunamadı"); break;
// }


// Console.WriteLine("Lütfen bir gün giriniz");
// string gun = Console.ReadLine();

// switch (gun)
// {

//     case "pazartesi": Console.WriteLine("Hafta içi"); break;
//     case "salı": Console.WriteLine("Hafta içi"); break;
//     case "çarşamba": Console.WriteLine("Hafta içi"); break;
//     case "perşembe": Console.WriteLine("Hafta içi"); break;
//     case "cuma": Console.WriteLine("Hafta içi"); break;
//     case "cumartesi": Console.WriteLine("Hafta sonu"); break;
//     case "pazar": Console.WriteLine("Hafta sonu"); break;
//   default: Console.WriteLine("Böyle bir gün yok! hafta içi veya hafta sonu olduğu bulunamaz"); break;
//}
//Console ile Girilen İki Metinden Uzun Olanını Yazdırma

// string metin1;
// string metin2;
// Console.Write("1.Metni Giriniz : ");
// metin1 = Console.ReadLine();
// Console.Write("2.Metni Giriniz : ");
// metin2 = Console.ReadLine();
// if (metin2.Length < metin1.Length)
// {
//     Console.WriteLine("Birinci Girdiğiniz Metin Daha Uzundur ve {0} Karakterden Oluşmaktadır. 2. Metinden {1} karakter daha uzundur.", metin1.Length, (metin1.Length - metin2.Length));
// }
// else if (metin2.Length > metin1.Length)
// {
//     Console.WriteLine("İkinci Girdiğiniz Metin Daha Uzundur ve {0} Karakterden Oluşmaktadır. 1. Metinden {1} karakter daha uzundur.", metin2.Length, (metin2.Length - metin1.Length));
// }
// else
// {
//     Console.WriteLine("Her iki Metnin Uzunluğuda {0} karakterdir.");
//}

//Genişliği ve yüksekliği kullanıcı tarafından verilen dikdörtgen oluşturma örneği:


Console.Write("Yüksekliği Girin : ");
int yukseklik = Convert.ToInt32(Console.ReadLine());
Console.Write("Genişliği Girin : ");
int genislik = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= yukseklik; i++)
{
    for (int j = 1; j <= genislik; j++)
    {
        if (i == 1 || i == yukseklik)
            Console.Write("*");
        else
            if (j == 1 || j == genislik)
            Console.Write("**");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}