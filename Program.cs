namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your CVC: ");
            var cvc = Console.ReadLine();
            Console.Write("Enter your card number: ");
            var cardNumber = Console.ReadLine();
            Console.Write("Enter when your card expires: ");
            var expiryDate = Console.ReadLine();

            try
            {
                CreditCard creditCard = new CreditCard(name, cvc, cardNumber, expiryDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    public class CreditCard
    {
        public string Name { get; private set; }
        public string Cvc { get; private set; }
        public string CardNumber { get; private set; }
        public string ExpiryDate { get; private set; }

        public CreditCard(string name, string cvc, string cardNumber, string expiryDate)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be empty");

            if (string.IsNullOrEmpty(cvc))
                throw new ArgumentException("CVC cannot be empty");

            if (string.IsNullOrEmpty(cardNumber))
                throw new ArgumentException("Card number cannot be empty");

            if (string.IsNullOrEmpty(expiryDate))
                throw new ArgumentException("Expiry date cannot be empty");

            Name = name;
            Cvc = cvc;
            CardNumber = cardNumber;
            ExpiryDate = expiryDate;
        }
    }
}
