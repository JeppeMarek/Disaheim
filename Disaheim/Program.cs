namespace Disaheim
{
    public class Program
    {
        static void Main(string[] args)
        {
            Utility utility = new Utility();
            Book bookOne = new Book("ID", "Title", 20);
            Amulet amuletOne = new Amulet("ID", Level.high,"Design");
            utility.GetValueOfBook(bookOne);
            utility.GetValueOfAmulet(amuletOne);

        }
    }
}
