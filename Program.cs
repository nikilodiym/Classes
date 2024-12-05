namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (only 9s): ");
            string input = Console.ReadLine();

            try
            {
                int number = Convert.ToInt32(input);
                Console.WriteLine("The number is: " + number);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is out of range for int type");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number");
            }
        }
    }
}
