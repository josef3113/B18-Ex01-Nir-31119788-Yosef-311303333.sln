using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18_Ex01_011
{ 
    public class B18_Ex01_011
    {   
        public static void StartEx_01_011(int i_CountValueToGet = 3)
        {
            Console.WriteLine("Welcome to EX_011");
            string[] arrOfBinaryNumbers = new string[i_CountValueToGet];
            for (int i = 0; i < i_CountValueToGet; i++)
            {
                arrOfBinaryNumbers[i] = Input();
            }

            for (int i = 0; i < i_CountValueToGet; i++)
            {
                int dechimal = BinaryNumToDechimal(arrOfBinaryNumbers[i]);
                Console.WriteLine("{0}", dechimal);
            }
      
        }

        public static string Input()
        {
            string stringBinaryNum =null ;
            bool legalInput = false;
            while ( !legalInput)
            {

                stringBinaryNum = Console.ReadLine();
                int oneInString = CountElementsInString(stringBinaryNum, '1');
                int zeroInNumber = CountElementsInString(stringBinaryNum, '0');

                if (stringBinaryNum.Length == 9 && (oneInString + zeroInNumber) == 9 )
                {
                        legalInput = true;
                    
                }
                else
                {
                    Console.WriteLine("wrong input try again");
                }
            }
            

            return stringBinaryNum;
        }

        public static int CountElementsInString(string i_StringToCheck, char i_Elememnt)
        {
            int countOfElement = 0;
            foreach (var item in i_StringToCheck)
            {
                if (item == i_Elememnt)
                {
                    countOfElement ++;   
                }
            }
            return countOfElement;
        }

        public static int BinaryNumToDechimal(string i_stringToConvert)
        {
            int numberBinary = int.Parse(i_stringToConvert);
            int numberDechimal = 0;
            int powerNow = 1;
            while (numberBinary > 0)
            {
                if (numberBinary % 10 == 1)
                {
                    numberDechimal += (numberBinary % 10) * powerNow;
                }
                powerNow *= 2;
                numberBinary = numberBinary / 10;
            }
            return numberDechimal;
        }
    }

    
}
