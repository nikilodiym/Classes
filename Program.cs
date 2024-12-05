namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Passport
    {
        private string passportNumber;
        private string ownerName;
        private DateTime issueDate;

        public Passport(string passportNumber, string ownerName, DateTime issueDate)
        {
            if (string.IsNullOrEmpty(passportNumber))
            {
                throw new ArgumentException("Passport number cannot be empty");
            }

            if (string.IsNullOrEmpty(ownerName))
            {
                throw new ArgumentException("Owner name cannot be empty");
            }

            if (issueDate == DateTime.MinValue)
            {
                throw new ArgumentException("Issue date cannot be empty");
            }

            this.passportNumber = passportNumber;
            this.ownerName = ownerName;
            this.issueDate = issueDate;
        }

        public string PassportNumber
        {
            get { return passportNumber; }
        }

        public string OwnerName
        {
            get { return ownerName; }
        }

        public DateTime IssueDate
        {
            get { return issueDate; }
        }
    }
}
