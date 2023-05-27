namespace Country
{
    public class Citizen
    {

        private DateTime dateOfBirth;

        public int Age()
        {
            DateTime now = DateTime.Now;
            return (now - dateOfBirth).Days / 365;
        }
    }

    public class Gender: Citizen
    {
        protected string sheMale = "sheMale";
    }

    public class Individual: Gender

    {
        public string surName = "Muriuki";

        // Method should be string as the protected variable is string
        public string isSheMale()
        {
            return sheMale;
        }
    }

    public class Hustler
    {
        static void Main(string[] args)
        {
            Citizen waMuriuki = new Citizen();

            Gender theyThem = new Gender();

            Individual manSolo = new Individual();

            Console.WriteLine("Age is " + manSolo.Age());

            Console.WriteLine("Surname is " + manSolo.surName);

            Console.WriteLine("The gender is: " + manSolo.isSheMale());

        }
    }
}