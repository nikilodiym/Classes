namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a logical expression: ");
            string input = Console.ReadLine();

            try
            {
                bool result = EvaluateLogicalExpression(input);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static bool EvaluateLogicalExpression(string expression)
        {
            expression = expression.Replace(" ", "");

            string[] parts = expression.Split(new[] { "<", ">", "<=", ">=", "==", "!=" }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 2)
            {
                throw new ArgumentException("Invalid expression");
            }

            int leftOperand = int.Parse(parts[0]);
            int rightOperand = int.Parse(parts[1]);

            string op = expression.Replace(parts[0], "").Replace(parts[1], "");

            switch (op)
            {
                case "<":
                    return leftOperand < rightOperand;
                case ">":
                    return leftOperand > rightOperand;
                case "<=":
                    return leftOperand <= rightOperand;
                case ">=":
                    return leftOperand >= rightOperand;
                case "==":
                    return leftOperand == rightOperand;
                case "!=":
                    return leftOperand != rightOperand;
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }
    }
}
