namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Welcome to the Number Converter!-------");

            Console.WriteLine("Please select the conversion direction:");
            Console.WriteLine("1. Decimal to Binary");
            Console.WriteLine("2. Binary to Decimal");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ConvertDecimalToBinary();
                    break;
                case 2:
                    ConvertBinaryToDecimal();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void ConvertDecimalToBinary()
        {
            Console.WriteLine("Enter a decimal number:");
            int decimalNumber = int.Parse(Console.ReadLine());

            string binaryNumber = Convert.ToString(decimalNumber, 2);
            Console.WriteLine($"Binary equivalent: {binaryNumber}");
        }

        static void ConvertBinaryToDecimal()
        {
            Console.WriteLine("Enter a binary number:");
            string binaryNumber = Console.ReadLine();

            int decimalNumber = Convert.ToInt32(binaryNumber, 2);
            Console.WriteLine($"Decimal equivalent: {decimalNumber}");
        }
    }
}
