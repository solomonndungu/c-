using Family;
namespace Country
{
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