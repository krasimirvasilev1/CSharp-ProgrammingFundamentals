using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            String decryptedSentence = "";
            for (int i = 0; i < number ; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int numberOfletter = (int)letter + key;
                char decryptedLetter = (char)numberOfletter;
                decryptedSentence += decryptedLetter;
               
            }
            Console.WriteLine(decryptedSentence);
        }
    }
}
