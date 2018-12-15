using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Sequential
    {

        /*
          Solve The sudoku sequentially using backtrack 
         */

        static bool Sequential_solver(int[,]board) {
                
                // get unsigned cell
                int row=0, col=0;
                if (Is_fully_assigned(board,ref row,ref col)) {
                        return true;
                  }
                    
                    // get best choice for the choiced cell
                    for (int choice = 1; choice <= 9; choice++){
                        
                        if (Valid_choice(board, row, col, choice)) {
                            board[row, col] = choice;

                            if (Sequential_solver(board))
                            {
                                return true;
                            }
                            else {
                                board[row, col] = 0;
                            }
                        }
                    }
            return false;    
        }
        /*
         Check if current choice valid to put in row ,column and square prespective
             */
        private static bool Valid_choice(int[,] board, int row, int col, int choice)
        {
            return Check_row(board, row, choice) && Check_col(board, col, choice) && Check_square(board, row, col, choice);
        }


        /*
         Check if current choice is valid in his 3x3 square
             */
        private static bool Check_square(int[,] board, int row, int col, int choice)
        {
            int ratio = (int)Math.Sqrt(board.GetLength(0));
            int start_row = row - (row % ratio);
            int start_col = col - (col % ratio);
            for (int r = start_row; r < start_row + ratio; r++) {
                for (int c = start_col; c < start_col + ratio; c++) {
                    if (board[r, c] == choice) return false;
                }
            }
            return true;
        }
        /*
         Check if current choice valid in column
             */
        private static bool Check_col(int[,] board, int col, int choice)
        {
            for (int row = 0; row < board.GetLength(0); row++) {
                if (board[row, col] == choice) return false;
            }
            return true;
        }
        /*
         Check if current choice valid in row
             */
        private static bool Check_row(int[,] board, int row, int choice)
        {
            for (int col = 0; col < board.GetLength(1); col++) {
                if (board[row, col] == choice) return false;
            }
            return true;
        }
        /*
            check if the board is fully assigned and 
            if not return first unsigned cell
             */
        private static bool Is_fully_assigned(int[,] board,ref int row,ref int col)
        {
            for (row = 0; row < board.GetLength(0); row++) {
                for (col = 0; col < board.GetLength(1); col++) {
                    if (board[row, col] == 0) return false;
                }
            }
            return true;
        }


        /*
        Just for testing 
        static void Main(string[] args)
        {

            // Test the Sequential


            int[,] board = Get_random_board();

            Sequential_solver(board);
            for (int i = 0; i < board.GetLength(0); i++) {
                for (int j = 0; j < board.GetLength(1); j++) {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine("");
            }

        }
        */

        /*
         Read the boards from test file and return random board
         * Make sure to put the text file under bin/debug to be able to read
             */
        private static int[,] Get_random_board()
        {

            try
            {
               
                int[,] board = new int[9, 9];
               
                String file_name = "TestData.txt";
                String[] lines = File.ReadAllLines(file_name);


                Random random_choice = new Random();
                int choice_board = random_choice.Next(0, lines.Length);


                int row = 0, col = 0;
                foreach (char cell in lines[choice_board]) {
                    board[row, col] = cell - '0';
                    col++;
                    if (col == 9) {
                        col = 0;
                        row++;
                    }
                }
                return board;
            }
            catch (Exception e) {
                Console.WriteLine("TestData Files Not exist");
                Environment.Exit(0);
                return null;
            }

        }
    }
    
}
