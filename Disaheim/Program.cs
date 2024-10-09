namespace Disaheim
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Level_enumeration level = new Level_enumeration();

            Amulet amu = new Amulet("nej");
            Book book = new Book("Sut dadel","Sut figen");
            Console.WriteLine(book.ToString());
            Console.WriteLine(amu.ToString());
        }
    }
}
