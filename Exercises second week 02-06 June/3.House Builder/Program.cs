using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstMaterial = Console.ReadLine();
            var secondmaterial = Console.ReadLine();

           
            int priceFirstMaterialInt;
            int priceSecondMaterialInt;
            sbyte priceFirstMaterialSbyte;
            sbyte priceSecondMaterialSbyte;

            var first = sbyte.TryParse(firstMaterial, out priceFirstMaterialSbyte);
            var second = sbyte.TryParse(secondmaterial, out priceSecondMaterialSbyte);
            var third = int.TryParse(firstMaterial, out priceFirstMaterialInt);
            var fourth = int.TryParse(secondmaterial, out priceSecondMaterialInt);

            if (first && fourth)
            {
                long actualPrice = priceFirstMaterialSbyte * 4 + (long)priceSecondMaterialInt * 10;
                Console.WriteLine(actualPrice);
            }
            else if(second && third)
            {
                long actualPrice = priceSecondMaterialSbyte * 4 + (long)priceFirstMaterialInt * 10;
                Console.WriteLine(actualPrice);
            }
        }
    }
}
