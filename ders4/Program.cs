using metodlar;
using Mammals;

// Mathematic mat = new Mathematic();
// mat.bol(5, 3);
Console.WriteLine("Çalıştı sevcan");


// // Class 
// Human esra = new Human();
// esra.Name = "Esra";
// esra.Surname = "Sarıkaya";
// esra.Age = 2;
// esra.isHaveSalary = false;

// // Initialization init
// Human akif = new Human()
// {
//     Name = "Akif",
//     Surname = "Sarıkaya",
//     Age = 0,
//     isHaveSalary = false
// };

// Human elif = new()
// {
//     Name = "Elif Ikra",
//     Surname = "Sarıkaya",
//     Age = 8,
//     isHaveSalary = false
// };

Human sena = new();
sena.Name = "Sena";
sena.Surname = "Yaman";

// bool enough = Human.IsEnoughSalary(6000);

// if (enough)
// {
//     Console.WriteLine("Yterli maaş var");
// }
// else
// {
//     Console.WriteLine("Yterli maaş yok");
// }


if (Human.IsEnoughSalary(6000))
{
    Console.WriteLine("Yterli maaş var");
}
else
{
    Console.WriteLine("Yterli maaş yok");
}