using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftApplication
{
    class Gift
    {
        string[] tech;
        string[] makeup;
        string[] homeDecor;
        int[] highPrice;
        int[] midPrice;
        int[] lowPrice;
        int[] gift;

        public Gift()
        {

            tech = new string[3];
            makeup = new string[3];
            homeDecor = new string[3];
            highPrice = new int[3];
            midPrice = new int[3];
            lowPrice = new int[3];
           
        }


        public int[] GetGift(char uChoice1, char uChoice2)

        {
            tech[0] = "Powerbeats";
            tech[1] = "Laptop Case";
            tech[2] = "Phone Case";
            makeup[0] = "Sephora Vault";
            makeup[1] = "Urban Decay Eyeshadow Palette";
            makeup[2] = "E.L.F Gift Set";
            homeDecor[0] = "Vanity Mirror";
            homeDecor[1] = "Lamp";
            homeDecor[2] = "Candles";
            highPrice[0] = 99;
            highPrice[1] = 90;
            highPrice[2] = 70;
            midPrice[0] = 35;
            midPrice[1] = 45;
            midPrice[2] = 50;
            lowPrice[0] = 10;
            lowPrice[1] = 8;
            lowPrice[2] = 9;
            

            if (uChoice1 == 'a' && uChoice2 == 'c')
            {
                Console.WriteLine("We suggest " + tech[0] + ", " + "which costs, " + "$" + highPrice[0] + ".");
            }
            if (uChoice1 == 'a' && uChoice2 == 'b')

            {
                Console.WriteLine("We suggest " + tech[1] + ", " + "which costs " + "$" + midPrice[0] + ".");
            }
            if (uChoice1 == 'a' && uChoice2 == 'a')
            {
                Console.WriteLine("We suggest " + tech[2] + ", " + "which costs " + "$" + lowPrice[0] + ".");
            }

            if (uChoice1 == 'b' && uChoice2 == 'a')
            {
                Console.WriteLine("We suggest " + makeup[2] + ", " + "which costs " + "$" + lowPrice[1] + ".");

            }
            if (uChoice1 == 'b' && uChoice2 == 'b')

            {
                Console.WriteLine("We suggest " + makeup[1] + ", " + "which costs " + "$" + midPrice[1] + ".");
            }
            if (uChoice1 == 'b' && uChoice2 == 'c')
            {
                Console.WriteLine("We suggest " + makeup[0] + ", " + "which costs " + "$" + highPrice[1] + ".");
            }
            if (uChoice1 == 'c' && uChoice2 == 'a')
            {
                Console.WriteLine("We suggest " + homeDecor[2] + ", " + "which costs " + "$" + lowPrice[2] + ".");
            }
            if (uChoice1 == 'c' && uChoice2 == 'b')
            {
                Console.WriteLine("We suggest " + homeDecor[1] + ", " + "which costs " + "$" + midPrice[2] + ".");
            }
            if (uChoice1 == 'c' && uChoice2 == 'c')
            {
                Console.WriteLine("We suggest " + homeDecor[0] + ", " + "which costs, " + "$" + highPrice[2] + ".");
            }
            return gift;
        }
    }   
    }


