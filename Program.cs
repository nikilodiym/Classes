namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Write something: ");
            string input = Console.ReadLine();
            Console.WriteLine($"You wrote: {input}");
        }
    }
}
