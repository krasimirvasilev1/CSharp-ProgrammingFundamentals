using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1.Book_Library
{
    class Library
    {
        public string title { get; set; }
        public DateTime dateOfRelease { get; set; }
    }

    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public DateTime releaseDate { get; set; }
        public string isbnNumber { get; set; }
        public double priceOfBook { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());

            Dictionary<string, DateTime> dictionaryAll = new Dictionary<string, DateTime>();
            DateTime dateToStartPrinting = new DateTime();

            Dictionary<string, DateTime> dictionarySorted = new Dictionary<string, DateTime>();
            for (int i = 1; i <= stopNumber; i++)
            {
                List<string> bookCharacteristics = Console.ReadLine().Split().ToList();

                Book book = new Book
                {

                    title = bookCharacteristics[0],
                    author = bookCharacteristics[1],
                    publisher = bookCharacteristics[2],
                    releaseDate = DateTime.ParseExact(bookCharacteristics[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    isbnNumber = bookCharacteristics[4],
                    priceOfBook = double.Parse(bookCharacteristics[5])
                };


                Library library = new Library
                {
                    title = book.title,
                    dateOfRelease = book.releaseDate

                };


                dictionaryAll[library.title] = library.dateOfRelease;

            }
            var lastLineReadFromConsole = Console.ReadLine();
            dateToStartPrinting = DateTime.ParseExact(lastLineReadFromConsole, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var item in dictionaryAll)
            {
                var compareTwoDates = DateTime.Compare(dateToStartPrinting, item.Value);
                if (compareTwoDates < 0)
                {
                    dictionarySorted[item.Key] = item.Value;
                }
            }

            var orderedDictionary = dictionarySorted.OrderBy(p => p.Value).ThenBy(f => f.Key);
            foreach (var item in orderedDictionary)
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", item.Key, item.Value);
            }

        }
    }
}


