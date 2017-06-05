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
            string binaryPacket = "";
            string[] binaryNumberArray;
            //get the user input
            Console.WriteLine("Saisissez le nombre binaire à convertire en HexaDecimal");
            binaryNumber = Console.ReadLine();

            //get a substring of 4 char from the string and store it in an array
            for(int i = 0; i < binaryNumber.Length; i ++)
            {
                binaryPacket = binaryNumber.Substring(0, 4);
                binaryNumber = returnHexFromBinary(binaryPacket);
            }
            Console.WriteLine(binaryNumber);
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

        static IEnumerable<string> chunkStringIntoPacketsOfFourChar(string str)
        {
            int numberOfCharInString = 0;
            //compte le nombre de caractères dans la string
            foreach(char unCharactere in str)
            {
                numberOfCharInString++;
            }
            //si le nombre de caractères dans la string n'est pas un multiple de 4 rajouter des zéros à la fin de la string
            if(numberOfCharInString % 4 != 0)
            {
                str = str + "0";
                

            }
            //foreach

            //return Enumerable.Range(0, str.Length / 4)
        }
    }
}
