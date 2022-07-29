namespace ClassMember
{
    class Ornek
    {
        public int x { get; set; }
        public Ornek()
        {
            Console.WriteLine("nesne oluşturuldu");
        }
        static Ornek()
        {
            Console.WriteLine("constructerden önce çalıştı");
        }
    }
}
