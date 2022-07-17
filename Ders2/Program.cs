Console.WriteLine("Merhaba");
string name = "sevcan sarıkaya";


int age = 19;
double salary = 250.25;
float salary2 = 250.25F;
decimal salary3 = 50.25M;



Console.WriteLine(name + "; " + age + " yaşında ve " + salary + " TL kazanıyor");
Console.WriteLine("{0}; {1} yaşında ve {2} TL kazanıyor", name, age, salary);
Console.WriteLine($"{name}; {age} yaşında ve {salary} TL kazanıyor");
var message = $"{name}; {age} yaşında ve {salary} TL kazanıyor";
var message2 = name + "; " + age + " yaşında ve " + salary + " TL kazanıyor";
Console.WriteLine(message);
Console.WriteLine(message2);

// Console.WriteLine("Maximum integer {0} and mimimum integer {1}", int.MaxValue, int.MaxValue);
// Console.WriteLine("Maximum integer " + int.MaxValue);