namespace Disaheim
{
    public class Program
    {
        static void Main(string[] args)
        {
            Utility utility = new Utility();
            Book bookOne = new Book("ID", "Title", 20);
            Amulet amuletOne = new Amulet("ID", Level.high,"Design");
            Course c1 = new Course("ID", 65);
            utility.GetValueOfBook(bookOne);
            utility.GetValueOfAmulet(amuletOne);
            Console.WriteLine(utility.GetValueOfCourse(c1));


        }
    }
}
