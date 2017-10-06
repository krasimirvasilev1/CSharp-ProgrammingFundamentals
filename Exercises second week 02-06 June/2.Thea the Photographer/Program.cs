using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var picturescount = int.Parse(Console.ReadLine());
            var singlePicTimeSeconds = int.Parse(Console.ReadLine());
            var FilterPercentage = int.Parse(Console.ReadLine());
            var singlePicUploadTime = int.Parse(Console.ReadLine());

            var filterTimeSeconds = (long)picturescount * singlePicTimeSeconds;
            var picturesToUploadCount = (long)Math.Ceiling(picturescount * (FilterPercentage / 100d));
            var uploadTimeSeconds = picturesToUploadCount * singlePicUploadTime;

            var totalTimeInSeconds = uploadTimeSeconds + filterTimeSeconds;
            var totaltimeNeeded = TimeSpan.FromSeconds(totalTimeInSeconds);
            Console.WriteLine(totaltimeNeeded.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
