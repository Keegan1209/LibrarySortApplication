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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibrarySortApplication
{
    /// <summary>
    /// KEEGAN FRANK ST10114501 
    /// PROG POE TASK 1
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        // TASK 2 + 3 FEATURES
        private void btnIdentifyAreas_Click(object sender, RoutedEventArgs e)
        {
            MatchColumns form = new MatchColumns();

            form.ShowDialog();
        }

        private void btnCallNumber_Click(object sender, RoutedEventArgs e)
        {
            FindCallNumbers form = new FindCallNumbers();

            form.ShowDialog();
        }



        // OPENS REPLACE BOOKS GAME. 
        private void btnReaplaceBooks_Click(object sender, RoutedEventArgs e)
        {
            SortList sortList = new SortList();
            sortList.DeweyDecimal();
            sortList.Show();


        }


        // HOUSE KEEPING DRAG AND MOVE MAIN WINDOW AND CLOSE APPLICATION
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void LoginRegisterMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        

        private void btnEnd_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult prompt = MessageBox.Show("Are you sure you want to exit?", "Notice", MessageBoxButton.YesNo, MessageBoxImage.Warning); // exit message 

            if (prompt == MessageBoxResult.Yes)
            {

                Close();
            }
            else if (prompt == MessageBoxResult.No)
            {
                MessageBox.Show("Press OK to resume", "Continue App", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
