
int [] sayilar = new int [4];

sayilar[0]=21;
sayilar[1]=12;
sayilar[2]=13;
sayilar[3]=25;
 
// for (int i = 0; i < sayilar.Length; i++)
// {
//     Console.WriteLine(sayilar[i]);
// }
// Array.Clear(sayilar,0,sayilar.Length);  //clear dizi elemanlarının varsayılan değerini yapar. 
// for (int i = 0; i < sayilar.Length; i++)
// {
//      Console.WriteLine(sayilar[i]);
// }

int []sayilar2 = new int [3];
 
 for (int i = 0; i < sayilar2.Length; i++)
 {
    Console.WriteLine(sayilar2[i]);
 }
Array.Copy(sayilar,sayilar2,3); //dizinin istenilen eleman aralığını başka bir diziye koyalar 
for (int i = 0; i < sayilar2.Length; i++)
{
     Console.WriteLine(sayilar2[i]);
}

