using System;

namespace TicTacToe
{
    class Program
    {
        public static string Computer;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe!");
            InitializeBoard();
            ChooseLetter();
        }
       
        static  void  InitializeBoard()
        {
            
            char[] board = new char[10];

           
            for (int index = 1; index < 10; index++)
            {
                board[1] = ' ';
            }
            

            }
        public static void ChooseLetter()
        {
            Console.WriteLine("select 'X' or 'O': ");
            char Player = char.Parse(Console.ReadLine());
            if (Player == 'X')
            {
                Computer = "O";
            }
            else if(Player == 'O')
            {
                Computer = "X";
            }
            else
            {
                Console.WriteLine("wrong input");
            }
        }

    }
 }

    


