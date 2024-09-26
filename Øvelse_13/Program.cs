using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Øvelse_13
{
    enum ChessPiece
    {
        EmptySpace,
        Pawn,
        Bishop,
        Knight,
        Rook,
        Queen,
        King

    }
    internal class Program
    {
        static int[,] chessBoard = new int[8, 8];

        static void Main(string[] args)
        {
            string playing = "y";

            SetupChessBoard();

            Console.WriteLine("Welcome to chess");
            Console.WriteLine("This is a console version of chess which means the Pieces are represented by numbers");
            Console.WriteLine("EmptySpace = 0, Pawn = 1, Bishop = 2, Knight = 3, Rook = 4, Queen = 5, King = 6");
            Console.WriteLine("Do you wanna play? y/n");

            playing = Console.ReadLine();

            while (playing == "y")
            {
                Console.WriteLine("Here is the current board:");
                WriteChessBoard();
                Console.ReadLine();
                
            }

            Console.WriteLine("The program will now terminate");
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Writes the chessboard to console
        /// </summary>
        static void WriteChessBoard()
        {
            for (int x = 0; x < chessBoard.GetLength(0); x++)
            {
                Console.WriteLine("* - * - * - * - * - * - * - * - *");
                Console.Write("| ");
                for (int y = 0; y < chessBoard.GetLength(1); y++)
                {
                    Console.Write(chessBoard[x, y] + " ");
                    Console.Write("| ");
                }
                Console.WriteLine();

            }
            Console.WriteLine("* - * - * - * - * - * - * - * - *");
        }

        /// <summary>
        /// Sets up a fresh chessboard
        /// </summary>
        static void SetupChessBoard()
        {
            chessBoard[0, 0] = (int)ChessPiece.Rook;
            chessBoard[0, 1] = (int)ChessPiece.Knight;
            chessBoard[0, 2] = (int)ChessPiece.Bishop;
            chessBoard[0, 3] = (int)ChessPiece.Queen;
            chessBoard[0, 4] = (int)ChessPiece.King;
            chessBoard[0, 5] = (int)ChessPiece.Bishop;
            chessBoard[0, 6] = (int)ChessPiece.Knight;
            chessBoard[0, 7] = (int)ChessPiece.Rook;

            chessBoard[1, 0] = (int)ChessPiece.Pawn;
            chessBoard[1, 1] = (int)ChessPiece.Pawn;
            chessBoard[1, 2] = (int)ChessPiece.Pawn;
            chessBoard[1, 3] = (int)ChessPiece.Pawn;
            chessBoard[1, 4] = (int)ChessPiece.Pawn;
            chessBoard[1, 5] = (int)ChessPiece.Pawn;
            chessBoard[1, 6] = (int)ChessPiece.Pawn;
            chessBoard[1, 7] = (int)ChessPiece.Pawn;

            chessBoard[6, 0] = (int)ChessPiece.Pawn;
            chessBoard[6, 1] = (int)ChessPiece.Pawn;
            chessBoard[6, 2] = (int)ChessPiece.Pawn;
            chessBoard[6, 3] = (int)ChessPiece.Pawn;
            chessBoard[6, 4] = (int)ChessPiece.Pawn;
            chessBoard[6, 5] = (int)ChessPiece.Pawn;
            chessBoard[6, 6] = (int)ChessPiece.Pawn;
            chessBoard[6, 7] = (int)ChessPiece.Pawn;

            chessBoard[7, 0] = (int)ChessPiece.Rook;
            chessBoard[7, 1] = (int)ChessPiece.Knight;
            chessBoard[7, 2] = (int)ChessPiece.Bishop;
            chessBoard[7, 3] = (int)ChessPiece.Queen;
            chessBoard[7, 4] = (int)ChessPiece.King;
            chessBoard[7, 5] = (int)ChessPiece.Bishop;
            chessBoard[7, 6] = (int)ChessPiece.Knight;
            chessBoard[7, 7] = (int)ChessPiece.Rook;
        }

    }
}
