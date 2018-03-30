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

            int size = 6;
            char[,] myBoard = CreatBoard(size);
            PrintBoardDamka(myBoard, size);
        }
        public static char[,] CreatBoard(int i_Size = 3)
        {
            char[,] boardOfGame = new char[i_Size, i_Size];

            for (int i = 0; i < i_Size; i++)
            {
                for (int j = 0; j < i_Size; j++)
                {
                    //  boardOfGame[i, j] = '1';
                }
            }

            return boardOfGame;

        }

        public static void PrintBoardDamka(char[,] i_BoardToPrint, int i_Size)
        {
            char signRow = 'a', signCol = 'A';
            for (int i = 0; i < i_Size; i++)
            {
                Console.Write("  " + signCol + "  ");
                signCol++;
            }
            Console.WriteLine();
            for (int i = 0; i < i_Size; i++)
            {
                Console.Write("========={0}{1}", Environment.NewLine, signRow);
                for (int j = 0; j < i_Size; j++)
                {
                    Console.Write("| " + i_BoardToPrint[i, j] + " ");
                }
                Console.WriteLine("|");
                signRow++;

            }

        }

    }
}
