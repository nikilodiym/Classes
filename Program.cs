namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter a binary number:");
                string binaryString = Console.ReadLine();

                int decimalNumber = Convert.ToInt32(binaryString, 2);

                Console.WriteLine("Decimal representation: " + decimalNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid binary number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input out of range. Please enter a binary number within the range of Int32.");
            }
        }
    }
}
