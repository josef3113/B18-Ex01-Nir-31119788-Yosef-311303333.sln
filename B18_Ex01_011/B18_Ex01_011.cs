using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18_Ex01_011 
{ 
    public class B18_Ex01_011
    {    
        public static void StartEx_01_011(int i_CountValueToGet = 3, int i_LenghtOfNumber = 9)
        {
            Console.WriteLine("Welcome to EX_011");
            string[] arrOfBinaryNumbers = new string[i_CountValueToGet];
            for (int i = 0; i < i_CountValueToGet; i++)
            {
                arrOfBinaryNumbers[i] = Input(i_LenghtOfNumber);
            }

            int[]  arrDechimal                      = ArrOfBinaryToArrOfInt (arrOfBinaryNumbers);
            float  avgOfOneInNumbers                = (float)CountOfElementsInArry(arrOfBinaryNumbers, '1') / (i_CountValueToGet * i_LenghtOfNumber);
            float  avgOfZeroInNumbers               = (float)CountOfElementsInArry(arrOfBinaryNumbers, '0') / (i_CountValueToGet * i_LenghtOfNumber);
            int    countOfSeriesDescendingInNumbers = CountOfSeriesDescendingInArry(arrDechimal);
            int    countOfPow2InNumbers             = CountOfPow2InArry(arrDechimal);
            float  avgOfDechimalNumbers             = AvgOfIntArry(arrDechimal);

            Console.WriteLine("The numbers binary is :");
            PrintArrOfString (arrOfBinaryNumbers);
            Console.WriteLine("In dechimal numbers is :");
            PrintArrOfString( ArrOfIntToArrOfString ( arrDechimal));
            Console.WriteLine("The averg of '1' in numbers is :{0}", avgOfOneInNumbers);
            Console.WriteLine("The averg of '0' in numbers is :{0}", avgOfZeroInNumbers);
            Console.WriteLine("The count of series descending in numbers is :{0}", countOfSeriesDescendingInNumbers);
            Console.WriteLine("The count of power of '2' in numbers is :{0}", countOfPow2InNumbers);
            Console.WriteLine("The averg of numbers is :{0}", avgOfDechimalNumbers);

        }

        public static float AvgOfIntArry(int[] i_ArryToAvg)
        {
            int sumOfAllArry = 0;
            for(int i = 0; i < i_ArryToAvg.Length; i++)
            {
                sumOfAllArry += i_ArryToAvg[i];
            }
            return (float)sumOfAllArry / i_ArryToAvg.Length;
        }

        public static int CountOfPow2InArry(int[] i_ArryToCheck)
        {
            int countOfPow2 = 0;
            for (int i = 0; i < i_ArryToCheck.Length; i++)
            {
                if ( IsPowOf2(i_ArryToCheck[i]))
                {
                    countOfPow2++;
                }
            }
            return countOfPow2;
        }

        public static int CountOfSeriesDescendingInArry(int[] i_ArryToCheck)
        {
            int countOfSeriesDescending = 0;
            for(int i = 0; i < i_ArryToCheck.Length; i++)
            {
                if(IsSeriesDescending(i_ArryToCheck[i] ))
                {
                    countOfSeriesDescending++;
                }
            }
            return countOfSeriesDescending;
        }

        public static int CountOfElementsInArry(string[] i_ArryToCheck, char i_ElementToCount)
        {
            int countOfDigit = 0;
            for(int i = 0; i < i_ArryToCheck.Length; i++)
            {
                countOfDigit += CountElementsInString(i_ArryToCheck[i], i_ElementToCount);
            }
            return countOfDigit;
        }

        public static int CountElementsInString(string i_StringToCheck, char i_ElementToCount)
        {
            int countOfElement = 0;
            foreach (var item in i_StringToCheck)
            {
                if (item == i_ElementToCount)
                {
                    countOfElement++;
                }
            }
            return countOfElement;
        }

        public static bool IsPowOf2(int i_Number)
        {
            bool answer = false;
            float log2Number = (float)Math.Log(i_Number, 2);
            if (log2Number == Math.Floor(log2Number)) // if will be mod so its not pow of 2;
            {
                answer = true;
            }

            return answer;
        }

        public static void PrintArrOfString(string[] i_ArrToPrint)
        {
            foreach (var item in i_ArrToPrint)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] ArrOfBinaryToArrOfInt (string[] i_ArrToConver)
        {
            int[] arrOfIntNumbers = new int[i_ArrToConver.Length];
            for(int i = 0; i < i_ArrToConver.Length; i++)
            {
                arrOfIntNumbers[i] = BinaryNumToDechimal(i_ArrToConver[i]);
            }
            return arrOfIntNumbers;
        }

        public static string[] ArrOfIntToArrOfString(int[] i_ArrToConver)
        {
            string[] arrOfIntNumbers = new string[i_ArrToConver.Length];
            for (int i = 0; i < i_ArrToConver.Length; i++)
            {
                arrOfIntNumbers[i] = i_ArrToConver[i].ToString();
            }
            return arrOfIntNumbers;
        }

        public static string Input(int i_LenghtOfNumber)
        {
            string stringBinaryNum =null ;
            bool legalInput = false;
            while ( !legalInput)
            { 
                stringBinaryNum = Console.ReadLine();
                int oneInString = CountElementsInString (stringBinaryNum, '1');
                int zeroInNumber = CountElementsInString (stringBinaryNum, '0');

                if (stringBinaryNum.Length == i_LenghtOfNumber && (oneInString + zeroInNumber) == i_LenghtOfNumber )
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

        

        public static int BinaryNumToDechimal (string i_stringToConvert)
        {
            int numberBinary = int.Parse(i_stringToConvert);
            int numberDechimal = 0;
            int powerNow = 1;
            while (numberBinary > 0)
            {
                if (numberBinary % 10 == 1)
                {
                    numberDechimal += 1 * powerNow;
                }
                powerNow *= 2;
                numberBinary = numberBinary / 10;
            }
            return numberDechimal;
        }

        public static bool IsSeriesDescending(int i_NumToCheck)
        {
            bool answer = true;
            int lastDigit = i_NumToCheck % 10;

            while (i_NumToCheck > 10)
            {
                i_NumToCheck /= 10;
                if (lastDigit > i_NumToCheck % 10)
                {
                    answer = false;
                    break;
                }
                lastDigit = i_NumToCheck % 10;
            }
            return answer;
        }
    }
}
