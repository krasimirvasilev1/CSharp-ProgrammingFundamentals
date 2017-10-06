using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photonumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double photosize = double.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double size = 0;
            Console.WriteLine("Name: DSC_{0:D4}.jpg", photonumber);
            Console.WriteLine("Date Taken: {0:D2}/{1:D2}/{2:D4} {3:D2}:{4:D2}", day, month, year, hours, minutes);
            if (photosize < 1024)
            {
                size = photosize;
                Console.WriteLine($"Size: {size}B");
            }
            else if (photosize>=1024 && photosize < 1048576)
            {
                size = photosize / 1000;
                Console.WriteLine($"Size: {size}KB");
            }
            else if (photosize >= 1048576)
            {
                size = photosize / 1000000;
                Console.WriteLine("Size: {0}MB",Math.Round(size,1));
            }
            if (widht > height)
            {
                Console.WriteLine("Resolution: {0}x{1} (landscape)", widht, height);
            }
            else if (widht == height)
            {
                Console.WriteLine("Resolution: {0}x{1} (square)", widht, height);
            }
            else if (widht < height)
            {
                Console.WriteLine("Resolution: {0}x{1} (portrait)", widht, height);
            }

        }
    }
}
