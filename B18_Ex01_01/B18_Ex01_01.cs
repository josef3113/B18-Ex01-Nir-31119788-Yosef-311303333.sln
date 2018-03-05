
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace B18_Ex01_01
{
   public class B18_Ex01_01
    {

        public static void Ex01_01_Start()
        {
            Console.WriteLine("Hey , Ex01_01");
            string strNumber = Console.ReadLine();
            int numberBin = int.Parse(strNumber);
            int numberDec=0;
            int oneInNumberBin = 0;
            int powerNow = 1;
            while (numberBin > 0)
            {
                if (numberBin % 10 == 1)
                {
                    numberDec += (numberBin % 10) * powerNow;
                    oneInNumberBin ++ ;

                }
                powerNow *= 2 ;
                numberBin = numberBin / 10;
            }
            
            int numbTest=strNumber.Count( x => char.IsDigit('1'));
            int sizeArr = 3;
            string[] arrString=new string [sizeArr];
            for (int i = 0; i < sizeArr; i++)
            {
                arrString[i] = Console.ReadLine();

            }
           // int num = 16;
          
            //for (int i = 0; i < sizeArr; i++)
            //{
            //    Console.WriteLine(arrString[i]);

            //}
            Console.WriteLine("num of one in all string is: {0}",CountOneInArrOfString(arrString, sizeArr));


            Console.WriteLine("The number is: {0} and one in number is: {1}",numberDec,oneInNumberBin);
            Console.WriteLine("The number is: {0} and one in number is: {1}", numberDec, numbTest);








            //char currentDigit = strTemp[0];


            //string stam=currentDigit.ToString();
            //int num = int.Parse(stam);



        }

        public static int CountOneInArrOfString(string[] i_ArrOfString, int i_SizeOfArry)
        {
            int countOne = 0;
            for (int i = 0; i < i_SizeOfArry; i++)
            {
                countOne += i_ArrOfString[i].Count(x => char.IsDigit('1'));
            }

            return countOne;

        }

        public static int CountOneInString(string i_StringToCheck)
        {
            int numberBin = int.Parse(i_StringToCheck);
            int oneInNumberBin = 0;
            while (numberBin > 0)
            {
                if (numberBin % 10 == 1)
                {
               
                    oneInNumberBin++;

                }
                
                numberBin = numberBin / 10;
            }
            return oneInNumberBin;
        }




    }
}
