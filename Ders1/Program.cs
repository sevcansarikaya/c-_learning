using Envanter;

Console.WriteLine("Merhaba");
// string name = "sevcan sarıkaya";

// byte cityNumber = 23;
// short certificateCount = 1000;
// int age = 19;

// double salary = 250.25;
// float salary2 = 250.25F;
// decimal salary3 = 50.25M;



// Console.WriteLine(name + "; " + age + " yaşında ve " + salary + " TL kazanıyor");
// Console.WriteLine("{0}; {1} yaşında ve {2} TL kazanıyor", name, age, salary);
// Console.WriteLine($"{name}; {age} yaşında ve {salary} TL kazanıyor");
// var message = $"{name}; {age} yaşında ve {salary} TL kazanıyor";
// var message2 = name + "; " + age + " yaşında ve " + salary + " TL kazanıyor";
// Console.WriteLine(message);
// Console.WriteLine(message2);

// Console.WriteLine($"Maximum integer {int.MaxValue} and mimimum integer {int.MinValue}");
// Console.WriteLine($"Maximum long {long.MaxValue} and mimimum long {long.MinValue}");
// Console.WriteLine($"Maximum byte {byte.MaxValue} and mimimum byte {byte.MinValue}");
// Console.WriteLine($"Maximum short {short.MaxValue} and mimimum short {short.MinValue}");
// Console.WriteLine($"Maximum double {double.MaxValue} and mimimum double {double.MinValue}");
// Console.WriteLine($"Maximum decimal {decimal.MaxValue} and mimimum decimal {decimal.MinValue}");
// Console.WriteLine($"Maximum float {float.MaxValue} and mimimum float {float.MinValue}");


// Conversation 
// Implicit Cast
// byte number0 = 200;
// short number1 = number0;
// int number2 = number1;
// long number3 = number2;
// Console.WriteLine(number3);

// Explicit Cast
// long number3 = 25555;
// int number2 = (int)number3;
// short number1 = (short)number2;
// byte number0 = (byte)number1;
// byte deneme = Convert.ToByte(number3);
// Console.WriteLine(number0);

// double salary = 52200;
// float salary2 = (float)salary;
// decimal salary3 = (decimal)salary;

// bool isMan = false;
// Console.WriteLine(isMan);
// if (isMan == true)
// {
//     Console.WriteLine("Bu bir erkek");
// }
// else
// {
//     Console.WriteLine("Bu bir kadın");
// }

// DateTime date = DateTime.Now;
// Console.WriteLine(date);
// Console.WriteLine(String.Format("{0:dd/MM/yyyy}", date));



// Product product = new Product();
// product.Name = "yeşil renkli abiye";
// product.Description = "Çok güzel bir ürün";
// product.Price = 200;
// product.DiscountedPrice = 100;
// product.CreatedDate = DateTime.Now;

// Console.WriteLine($"{product.Name} ürünün fiyatı {product.DiscountedPrice} TL dir");

// string s = "123";
// int y = Convert.ToInt32(s); //artık string türünü int e çevirebildik.


// int x = 15;

// Console.WriteLine(++x);    //ekrana 16 yazdırır.

// Console.WriteLine(x++);
// Console.WriteLine(x); // burda ilk yazdıgımızda 15 ekrana yazar ama x yıne artırılmıştır tekrar biz x i ekrana yazdırırsak 16 yazılır

// int x=10;
// switch (x)
// {
//     case 11:
//     Console.WriteLine("hata"); // yukarıdaki case sağlamadıgı için direkt burayı es geçti.
//      break ;
//      case 10:
//      Console.WriteLine("değer 10");
//      break;

// }
// int y=11;
// switch (y)
// {
//     case 3:
//     Console.WriteLine(3);
//     break;
//     case 14:
//     Console.WriteLine(14);
//     break;
//     case 11: goto case 14;


// }
// using static System.Console;
// FinishProgramGreeting("yusuf");

// void FinishProgramGreeting(string name)
// {
//     Console.WriteLine($"hello {name}; this program has been finished. see you");

// }






