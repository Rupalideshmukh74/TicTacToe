using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe!");
            InitializeBoard();
        }
       
        static  public void  InitializeBoard()
        {
            
            char[] board = new char[10];

           
            for (int index = 1; index < 10; index++)
            {
                board[1] = ' ';
            }
            
        }
    }

}
