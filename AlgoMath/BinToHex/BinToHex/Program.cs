using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string binaryNumber;
            string[] binaryNumberArray;
            string HexNumber = "";
            //get the user input
            Console.WriteLine("Saisissez le nombre binaire à convertire en HexaDecimal");
            binaryNumber = Console.ReadLine();

            //vérifie que le nombre de caractères est bien un multiple de 4
            int isMultipleOfFour = binaryNumber.Count() % 4;

            while(isMultipleOfFour != 0)
            {
                binaryNumber += "0";
                isMultipleOfFour = binaryNumber.Count() % 4;
            }



            //get a substring of 4 char from the string and store it in an array
            binaryNumberArray = Enumerable.Range(0, binaryNumber.Length / 4).Select(i => binaryNumber.Substring(i * 4, 4)).ToArray();

            //compare each substring of the array and returns a binary value
            foreach(var substring in binaryNumberArray)
            {
                HexNumber += returnHexFromBinary(substring);
            }
            Console.WriteLine(HexNumber);
            Console.ReadLine();
        }

        static string returnHexFromBinary(string binaryString)
        {
            string convertedString = "";

            switch(binaryString)
            {
                case "0000": convertedString = "0";break;
                case "0001": convertedString = "1"; break;
                case "0010": convertedString = "2"; break;
                case "0011": convertedString = "3"; break;
                case "0100": convertedString = "4"; break;
                case "0101": convertedString = "5"; break;
                case "0110": convertedString = "6"; break;
                case "0111": convertedString = "7"; break;
                case "1000": convertedString = "8"; break;
                case "1001": convertedString = "9"; break;
                case "1010": convertedString = "A"; break;
                case "1011": convertedString = "B"; break;
                case "1100": convertedString = "C"; break;
                case "1101": convertedString = "D"; break;
                case "1110": convertedString = "E"; break;
                case "1111": convertedString = "F"; break;
            }

            return convertedString;
        }
    }
}
