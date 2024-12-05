namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number word: ");
            string word = Console.ReadLine();
            int number = ConvertWordToNumber(word);
            Console.WriteLine($"The number is: {number}");
        }

        static int ConvertWordToNumber(string word)
        {
            switch (word.ToLower())
            {
                case "zero":
                    return 0;
                case "one":
                    return 1;
                case "two":
                    return 2;
                case "three":
                    return 3;
                case "four":
                    return 4;
                case "five":
                    return 5;
                case "six":
                    return 6;
                case "seven":
                    return 7;
                case "eight":
                    return 8;
                case "nine":
                    return 9;
                default:
                    throw new ArgumentException("Invalid number word.");
            }
        }
    }
}
