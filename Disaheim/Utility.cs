using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            double bookValue = book.Price;
            Console.WriteLine(bookValue);
            return bookValue;
        }
        public double GetValueOfAmulet(Amulet amulet)
        {
            double amuletValue = 0;
            switch (amulet.Quality)
            {
                case Level.low:
                    amuletValue = 12.5;
                    break;
                case Level.medium:
                    amuletValue = 20.0;
                    break;
                case Level.high:
                    amuletValue = 27.5;
                    break;
            }
            Console.WriteLine(amuletValue);
            return amuletValue;
        }
        public double GetValueOfCourse(Course course)
        {
            double duration = course.DurationInMinutes;
            int perHour = 875;
            double price = 0;
            int fullHours = (int)(duration / 60);
            double remainingMinutes = duration % 60;
            price = fullHours * perHour;
            if (remainingMinutes > 0)
            {
                price += perHour * (remainingMinutes / 60.0);
            }
            return price;
        }
    }
}
