namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a mathematical expression: ");
                string expression = Console.ReadLine();

                int result = CalculateExpression(expression);
                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static int CalculateExpression(string expression)
        {
            string[] numbers = expression.Split('*');
            int result = 1;

            foreach (string number in numbers)
            {
                if (!int.TryParse(number, out int num))
                {
                    throw new ArgumentException("Invalid expression");
                }

                result *= num;
            }

            return result;
        }
    }
}
