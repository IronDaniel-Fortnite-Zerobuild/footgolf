namespace footgolf
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            List<verseny> versenyzok = new();
            foreach (var sor in File.ReadAllLines("fob2016.txt"));
            {
                versenyzok.Add(new verseny(sor));
            }
            Console.WriteLine($"3.feladat enyi versenyzö indult el mindketö kategóriába: {versenyzok.Count()} !");

            int 






        }
    }
}
