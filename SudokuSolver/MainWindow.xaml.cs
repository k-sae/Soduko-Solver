using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SudokuSolver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public String[] lines;
        public MainWindow()
        {
            InitializeComponent();
           

        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            
            Solver s = new Solver();
            int[,] board = s.Get_random_board(lines);
            Window1 win2 = new Window1(board);
            win2.Show();

        }

        private void HomePageBrowse_Btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                 txtEditor.Text= File.ReadAllText(openFileDialog.FileName);
            lines = File.ReadAllLines(openFileDialog.FileName);
        }
    }
}
