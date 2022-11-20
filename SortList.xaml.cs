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
using System.Diagnostics;
using System.Timers;

namespace LibrarySortApplication
{
    /// <summary>
    /// KEEGAN FRANK ST10114501 
    /// PROG POE TASK 1
    /// </summary>
    public partial class SortList : Window
    {

        // TIMER GAMIFACTION FEATURES
        private Stopwatch _stopWatch;
        private Timer _timer;
        private const string StartTimer = "00:00:00"; 
        private Boolean sorted = false;

        ///GENERATES A NEW RANDOM EACH TIME ITS REQUIRED. 
        private Random ran = new Random();


        public SortList()
        {


            InitializeComponent();
            timerDisplay.Text = StartTimer;

            _stopWatch = new Stopwatch();
            _timer = new Timer(interval:1000);

            _timer.Elapsed += OnTimerElapse; 

          
        }

        private void OnTimerElapse(object sender, ElapsedEventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() => timerDisplay.Text = _stopWatch.Elapsed.ToString(format: @"hh\:mm\:ss"));
        }


        private void Timer_BTN(object sender, RoutedEventArgs e)
        {
            _stopWatch.Start();
            _timer.Start(); 
            
        }


        // LIST OF STRINGS THAT HOLDS THE DEWEY DECIMAL CALL NUMBERS
        List<string> dewey = new List<string>();

        // HOLDS LIST BOX 2 ITEMS
        private List<String> LB2_items = new List<string>();


        // NEW LIST USER ORDERS
        List<string> newList = new List<string>();

        // LIST TO COMPARE ORDERED LIST TO 
        List<String> sortedListLB2 = new List<string>();





       // BUTTON CLICK EVENT THAT DISPLAYS THE SORTED LIST TO THE USER ON LISTBOX 2
        private void sortListBTN_Click(object sender, RoutedEventArgs e)
        {

            

            Random rand = new Random();
            List<ListBoxItem> items = new List<ListBoxItem>();



            sortedListLB2 = LB2_items.OrderBy(x => rand.Next()).ToList();
            sortList(sortedListLB2);
            sorted = true;

            for (int i = 0; i < LB2_items.Count; ++i)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = sortedListLB2[i];
                items.Add(item);
            }
            LB2.Items.Clear();
            for(int i = 0; i < items.Count; ++i)
            {
                ListBoxItem listItem = items.ElementAt(i);
                LB2.Items.Add(listItem);
            }





        }

            
   




//------------------------------------------------------------------------------------------------------------------------------------------------------------//

        // SORT LIST ALGORITHM USING BUBBLE SORT
        // THIS METHOD SORTS LIST INTO ASCENDING ORDER. 
        private void sortList(List<String> list)
        {
            for (int i = 0; i < list.Count; ++i)
            {
                for (int j = i + 1; j < list.Count; ++j)
                {
                    int num1 = int.Parse(list.ElementAt(i).Substring(0, 3));
                    int num2 = int.Parse(list.ElementAt(j).Substring(0, 3));

                    if (num2 < num1)
                    {
                        String temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }

                }
            }
        }


//--------------------------------------------------------------------------------------------------------------------------------------------------------------


  // new list in listbox 1 that randomizes the order of the list. 
        private void setupLB1Items()
        {
            // Assigns list items to listbox 1
            List<ListBoxItem> items = new List<ListBoxItem>() { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 };
            Random rand = new Random();

            
            // RANDOMIZE ORDER OF LIST. 
            newList = dewey.OrderBy(x => rand.Next()).ToList();


            for (int i = 0; i < 10; ++i)
            {
                ListBoxItem item = items.ElementAt(i);
                String content = newList.ElementAt(i);
                item.Content = content;
            }


        }




        // checks if list is ordered. 
        private void checkList_BTN(object sender, RoutedEventArgs e)
        {


            if (sorted)
            {
                // STOP THE STOP WATCH AND RECORDS TIME.
                _stopWatch.Stop();
                _timer.Stop();
                String timeDisp = timerDisplay.Text;

                MessageBox.Show("Congratulations List is sorted in " + timeDisp + "!!", "Well Done", MessageBoxButton.OK);
            }

            else
            {
                MessageBox.Show("List Not Sorted", "Try Again", MessageBoxButton.OK);
            }







        }
//------------------------------------------------------------------------------------------------------------------------------------------------------------//


        /// Methods generate random dewey decimal items.



        // START GENERATE RANDOM DEWEY DECIMAL 
        public void DeweyDecimal()
        {
            String randomDewey;



            List<string> Genre = new List<String>() { "000", "100", "200", "300", "400", "500", "600", "700", "800", "900" };




            // GENERATES RANDOM DEWEY AND ASSIGNS IT TO THE LIST 
            for (int i = 0; i < 10; i++)
            {
                int a = ran.Next(99);
                randomDewey = Genre[i] + "." + a + "." + getRandom();
                dewey.Add(randomDewey);

            }

            // METHOD ASSIGNING LIST VALUES TO LISTBOX IN A RANDOM ORDER
            setupLB1Items();
        
        }


        // checks if list item already in list 
        private int existsInList(List<String> list, String value)
        {
            int result = -1;

            for (int i = 0; i < list.Count; ++i)
            {
                if (list.ElementAt(i).Equals(value)) result = i;
            }
            return result;
        }




        // GENERATE RANDOM AUTHOR INITIALS. 
        private String getRandom()
        {
           

            String b = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int length = 3;
            

            String random = "";
            for (int i = 0; i < length; i++)
            {

                int a = ran.Next(26);
                Console.WriteLine("Random integer: " +a);
                random = random + b.ElementAt(a);




            }
            
            return random;
        }



        // END GENERATE RANDOM DEWEY DECIMAL 





 /// ------------------------------------------------------------------------------------------------------------------------------------------------------------///



        /// METHODS THAT ALLOW YOU TO DRAG AND DROP ITEMS BETWEEN LISTBOXES

        private void LB1_Drop(object sender, DragEventArgs e)
        {
            // This casts 'e.Data.GetData()' as a ListBoxItem and if it isn't null
            // then the code will execute. 
            if (e.Data.GetData(DataFormats.FileDrop) is ListBoxItem listItem)
            {
                LB1.Items.Add(listItem);
                LB2_items.Remove((String)listItem.Content);
            }
        }



        private void LB2_Drop(object sender, DragEventArgs e)
        {
            // This casts 'e.Data.GetData()' as a ListBoxItem and if it isn't null
            // then the code will execute. 
            if (e.Data.GetData(DataFormats.FileDrop) is ListBoxItem listItem)
            {

                // adds listbox 1 items to lisbox 2
                LB2.Items.Add(listItem);
                
                int index = existsInList(LB2_items, (String)listItem.Content);
                if (index == -1) 
                { 
                    LB2_items.Add((String)listItem.Content);
                    sorted = false;
                } else
                {
                    LB2_items.Remove((String)listItem.Content);
                    LB2_items.Add((String)listItem.Content);
                    sorted = false;
                }
            }
        }








        // allows you to drag and drop from list box 1
        private void LB1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mPos = e.GetPosition(null);

            if (e.LeftButton == MouseButtonState.Pressed &&
                Math.Abs(mPos.X) > SystemParameters.MinimumHorizontalDragDistance &&
                Math.Abs(mPos.Y) > SystemParameters.MinimumVerticalDragDistance)
            {
                try
                {
                    // This gets the selected item
                    ListBoxItem selectedItem = (ListBoxItem)LB1.SelectedItem;
                    // you will need to remove it befor adding to a different list
                    LB1.Items.Remove(selectedItem);

                    // The actual dragdrop thingy
                   
                    DragDrop.DoDragDrop(this, new DataObject(DataFormats.FileDrop, selectedItem), DragDropEffects.Copy);

                    // This code will check if the listboxitem is inside a ListBox or not.
                    // This will stop the ListBoxItem you dragged from vanishing if you dont
                    // Drop it inside a listbox 

                    

                    if (selectedItem.Parent == null)
                    {
                        LB1.Items.Add(selectedItem);
                    }
                }
                catch { }
            }
        }


        // allows you to drag and drop from list box 2
        private void LB2_MouseMove(object sender, MouseEventArgs e)
        {
            Point mPos = e.GetPosition(null);

            if (e.LeftButton == MouseButtonState.Pressed &&
                Math.Abs(mPos.X) > SystemParameters.MinimumHorizontalDragDistance &&
                Math.Abs(mPos.Y) > SystemParameters.MinimumVerticalDragDistance)
            {
                try
                {
                    // This gets the selected item
                    ListBoxItem selectedItem = (ListBoxItem)LB2.SelectedItem;
                    // you will need to remove it befor adding to a different list
                    LB2.Items.Remove(selectedItem);

                    
                    DragDrop.DoDragDrop(this, new DataObject(DataFormats.FileDrop, selectedItem), DragDropEffects.Copy);

                    // This code will check if the listboxitem is inside a ListBox or not.
                    // This will stop the ListBoxItem you dragged from vanishing if you dont
                    

                    if (selectedItem.Parent == null)
                    {
                        LB2.Items.Add(selectedItem);
                    }
                }
                catch { }
            }
        }

        
    }
}
