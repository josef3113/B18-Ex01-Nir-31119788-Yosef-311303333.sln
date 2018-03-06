using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18_Ex01_02
{
    public class B18_Ex01_02
    {
        public static void Ex01_02_Start()   
        {
       
            Console.WriteLine("Hey , Ex01_02");
            string sandTime = MakeSandTime(5);
            Console.WriteLine(sandTime);
        }

    public static string MakeSandTime(int i_sizeToEnd)
        {
            StringBuilder srtingToPrint = new StringBuilder(i_sizeToEnd * i_sizeToEnd);
            
            int space = i_sizeToEnd/2 ;
            int currentSize = 3;
            srtingToPrint.Append(MakeLine(1, space));
            space--;
            while (space >= 0)
                {
                string lineToAdd = MakeLine(currentSize, space);
                srtingToPrint.Insert(0, lineToAdd);
                srtingToPrint.Append(lineToAdd);

                //srtingToPrint.Insert(0, MakeLine(currentSize, space));
                //srtingToPrint.Append(srtingToPrint.ToString(), 0,currentSize);


                //srtingToPrint.Append("\n");

                currentSize += 2 ;
                space-- ;
                }

            return srtingToPrint.ToString();   //  check this how to convert 



        }

        public static string MakeLineN(int i_NewLineSize, int i_MaxLineSize)
        {
            StringBuilder line = new StringBuilder(i_NewLineSize);
            for (int i = 0; i < i_NewLineSize; i++)
            {
                char chary;
                chary = i_NewLineSize + i < i_MaxLineSize ? ' ' : '*';
                line.Append(chary);
            }

            return String.Format("{0}{1}", line.ToString(), Environment.NewLine);
        }


        static string MakeLine(int i_Size,int i_Space)
        {
            // String spaceForCurrentLine = new String(' ', i_space);
            //string stringLine = new string('*', i_size);

            StringBuilder lineCurrent = new StringBuilder(i_Size);
            lineCurrent.Append(' ', i_Space);
            lineCurrent.Append('*', i_Size);
            // lineCurrent.Append(Environment.NewLine);
            //while (i_size > 0)
            //    {

            //    }
            // return   spaceForCurrentLine + stringLine + '\n';
            return string.Format("{0}{1}",lineCurrent,Environment.NewLine);
            //return lineCurrent.ToString();
        }
    }
}
