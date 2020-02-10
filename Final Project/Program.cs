using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Gift myGift = new Gift();
            Console.WriteLine("Gift Application");
            while (true)
            {

                char uChoice1 = GetInput1();
                char uChoice2 = GetInput2();

                myGift.GetGift(uChoice1, uChoice2);

                
                Console.ReadKey();
            }

        }
        public static char GetInput1()
        
        {
            string input1;
            Console.WriteLine("What kind of gift are you looking for?");
            Console.WriteLine("A- Technology");
            Console.WriteLine("B- Makeup");
            Console.WriteLine("C- Home Decor");
            input1 = Console.ReadLine();
            return char.Parse(input1);

        }
        public static char GetInput2()
        {
            string input2;
            Console.WriteLine("Choose your price range:");
            Console.WriteLine("A- $0-$10");
            Console.WriteLine("B-$11-$50");
            Console.WriteLine("C-$51-$100");
            input2 = Console.ReadLine();
            return char.Parse(input2);
        }

    }
}
