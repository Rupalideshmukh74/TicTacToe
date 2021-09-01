using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        void CheckingPosition()
        {
            char[] board = InitializeBoard();
        }
         public char[] InitializeBoard()
        {
            
            char[] board = new char[10];

           
            for (int index = 1; index < board.Length; index++)
            {
                board[index] = ' ';
            }
            return board;
        }
    }

}
