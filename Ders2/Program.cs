// Console.WriteLine("Merhaba");
// string name = "sevcan sarıkaya";


//int age = 19;
//double salary = 250.25;
//float salary2 = 250.25F;
//decimal salary3 = 50.25M;



//Console.WriteLine(name + "; " + age + " yaşında ve " + salary + " TL kazanıyor");
//Console.WriteLine("{0}; {1} yaşında ve {2} TL kazanıyor", name, age, salary);
//Console.WriteLine($"{name}; {age} yaşında ve {salary} TL kazanıyor");
//var message = $"{name}; {age} yaşında ve {salary} TL kazanıyor";
//var message2 = name + "; " + age + " yaşında ve " + salary + " TL kazanıyor";
//Console.WriteLine(message);
//Console.WriteLine(message2);

// Console.WriteLine("Maximum integer {0} and mimimum integer {1}", int.MaxValue, int.MaxValue);
// Console.WriteLine("Maximum integer " + int.MaxValue);


// Girilen 10 sayı içinde pozitif ve tek olan sayıların çarpımını yazdıran For döngüsü ile yapılmış Console örneği:
//  int sayi;
//         int sonuc=1;
//         for (int i = 1; i <= 10; i++)         
//         {             
// Console.WriteLine("{0}.Sayıyı Giriniz;", i);             
// sayi= Convert.ToInt32(Console.ReadLine());             
// if ((sayi> 0) && (sayi% 2 == 1))
//     {
//         sonuc*= sayi;
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Pozitif ve tek sayıların çarpımı : " + sonuc);

//continue kullanımı
// for (int sayi = 1; sayi <= 20; sayi++)
//     {
//         if (sayi == 9) /* eğer sayı 9 olduysa*/
//             continue;   /* devam et. 9 u yazma*/
//         Console.WriteLine("Sayı : {0}", sayi);
//     }

//     Console.ReadKey();



// string[] family = new string[10];
// family[0] = "Selahattin";
// family[1] = "Selahattin";
// family[2] = "Selahattin";

// for (int i = 0; i < family.Length; i++) //length diziznin eleman sayısı demek.
// {
//     Console.WriteLine(family[i]);
//}