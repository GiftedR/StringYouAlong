namespace StringMaker_Staggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringManager stringManager = new StringManager();
            Console.WriteLine(stringManager.Reverse("Sunbeam Tiger"));
            Console.WriteLine(stringManager);
            Console.WriteLine(stringManager.Reverse("Sunbeam Tiger", true));
            Console.WriteLine(stringManager.Equals("Sunbeam Tiger"));
            Console.WriteLine(stringManager.symmetric("ABBA"));
            Console.WriteLine(stringManager.symmetric("ABA"));
            Console.WriteLine(stringManager.symmetric("ABba"));
        }
    }
}