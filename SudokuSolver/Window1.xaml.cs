using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SudokuSolver
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Solver s = new Solver();
            int[,] board =new int[,] {
{ 0,0,7,4,0,0,0,9,0 }
,{0,1,3,0,0,0,6,0,0 },
{ 0,0,0,0,0,0,0,4,3 },
{ 1,0,0,0,0,0,2,7,0 },
{ 9,0,0,5,0,1,0,0,4 },
{ 0,6,4,0,0,0,0,0,1 },
{ 5,2,0,0,0,0,0,0,0 },
{ 0,0,6,0,0,0,9,8,0 },
{ 0,8,0,0,0,2,7,0,0} };

            for (int i = 0; i < 9; i++)
            {
                for (int x = 0; x < 9; x++)
                {

                    Label y = new Label();
                    if (board[x, i] == 0)
                    {
                        y.Content = " ";
                    }
                    else
                    {
                        if (x <= 2 && i <= 2)
                        {
                            y.Background = new SolidColorBrush(Colors.Red);
                            y.Content = board[x, i];
                            y.SetValue(Grid.ColumnProperty, i);
                            y.SetValue(Grid.RowProperty, x);
                            first.Children.Add(y);
                        }
                        if (x>2 &&x<=5 && i<=2)
                        {
                            y.Background = new SolidColorBrush(Colors.Red);
                            y.Content = board[x, i];
                            y.SetValue(Grid.ColumnProperty, i);
                            y.SetValue(Grid.RowProperty, x-3);
                            fourth.Children.Add(y);
                        }
                        if (x > 5 && x <= 8 && i <= 2)
                        {
                            y.Background = new SolidColorBrush(Colors.Red);
                            y.Content = board[x, i];
                            y.SetValue(Grid.ColumnProperty, i);
                            y.SetValue(Grid.RowProperty, x - 6);
                            seventh.Children.Add(y);
                        }
                        if (i> 2 && i <= 5 && x <= 2)
                        {
                            y.Background = new SolidColorBrush(Colors.Red);
                            y.Content = board[x, i];
                            y.SetValue(Grid.ColumnProperty, i-3);
                            y.SetValue(Grid.RowProperty, x);
                            Second.Children.Add(y);
                        }
                        if (i > 5 && i <= 8 && x <= 2)
                        {
                            y.Background = new SolidColorBrush(Colors.Red);
                            y.Content = board[x, i];
                            y.SetValue(Grid.ColumnProperty, i - 6);
                            y.SetValue(Grid.RowProperty, x);
                            Third.Children.Add(y);
                        }
                        if (i > 2 && i <= 5 && x > 2&& x<=5)
                        {
                            y.Background = new SolidColorBrush(Colors.Red);
                            y.Content = board[x, i];
                            y.SetValue(Grid.ColumnProperty, i - 3);
                            y.SetValue(Grid.RowProperty, x-3);
                            fifth.Children.Add(y);
                        }
                        if (i > 5 && i <= 8 && x > 5 && x <= 8)
                        {
                            y.Background = new SolidColorBrush(Colors.Red);
                            y.Content = board[x, i];
                            y.SetValue(Grid.ColumnProperty, i - 6);
                            y.SetValue(Grid.RowProperty, x - 6);
                            night.Children.Add(y);
                        }
                        if (i > 5 && i <= 8 && x > 2 && x <= 5)
                        {
                            y.Background = new SolidColorBrush(Colors.Red);
                            y.Content = board[x, i];
                            y.SetValue(Grid.ColumnProperty, i - 6);
                            y.SetValue(Grid.RowProperty, x - 3);
                            sixth.Children.Add(y);
                        }
                        if (i > 2 && i <= 5 && x > 5 && x <= 8)
                        {
                            y.Background = new SolidColorBrush(Colors.Red);
                            y.Content = board[x, i];
                            y.SetValue(Grid.ColumnProperty, i - 3);
                            y.SetValue(Grid.RowProperty, x - 6);
                            eight.Children.Add(y);
                        }
                    }
              
                }
                
            }
            s.SequentialSolve(board);
            for (int i = 0; i < 9; i++)
            {

                for (int x = 0; x < 9; x++)
                {
                    Label y = new Label();
                    if (x <= 2 && i <= 2)
                    {
                        y.Content = board[x, i];
                        y.SetValue(Grid.ColumnProperty, i);
                        y.SetValue(Grid.RowProperty, x);
                        first.Children.Add(y);
                    }
                    if (x > 2 && x <= 5 && i <= 2)
                    {
                       
                        y.Content = board[x, i];
                        y.SetValue(Grid.ColumnProperty, i);
                        y.SetValue(Grid.RowProperty, x - 3);
                        fourth.Children.Add(y);
                    }
                    if (x > 5 && x <= 8 && i <= 2)
                    {
                        
                        y.Content = board[x, i];
                        y.SetValue(Grid.ColumnProperty, i);
                        y.SetValue(Grid.RowProperty, x - 6);
                        seventh.Children.Add(y);
                    }
                    if (i > 2 && i <= 5 && x <= 2)
                    {
                        
                        y.Content = board[x, i];
                        y.SetValue(Grid.ColumnProperty, i - 3);
                        y.SetValue(Grid.RowProperty, x);
                        Second.Children.Add(y);
                    }
                    if (i > 5 && i <= 8 && x <= 2)
                    {
                       
                        y.Content = board[x, i];
                        y.SetValue(Grid.ColumnProperty, i - 6);
                        y.SetValue(Grid.RowProperty, x);
                        Third.Children.Add(y);
                    }
                    if (i > 2 && i <= 5 && x > 2 && x <= 5)
                    {
                      
                        y.Content = board[x, i];
                        y.SetValue(Grid.ColumnProperty, i - 3);
                        y.SetValue(Grid.RowProperty, x - 3);
                        fifth.Children.Add(y);
                    }
                    if (i > 5 && i <= 8 && x > 5 && x <= 8)
                    {
                       
                        y.Content = board[x, i];
                        y.SetValue(Grid.ColumnProperty, i - 6);
                        y.SetValue(Grid.RowProperty, x - 6);
                        night.Children.Add(y);
                    }
                    if (i > 5 && i <= 8 && x > 2 && x <= 5)
                    {
                        y.Content = board[x, i];
                        y.SetValue(Grid.ColumnProperty, i - 6);
                        y.SetValue(Grid.RowProperty, x - 3);
                        sixth.Children.Add(y);
                    }
                    if (i > 2 && i <= 5 && x > 5 && x <= 8)
                    {
                       
                        y.Content = board[x, i];
                        y.SetValue(Grid.ColumnProperty, i - 3);
                        y.SetValue(Grid.RowProperty, x - 6);
                        eight.Children.Add(y);
                    }
                }
            }
            }


                    //check if it wasnot == " " 


                }
        
        
    }
   

