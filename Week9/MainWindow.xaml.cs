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

namespace Week9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            var sw = new SecondWindow();
           
            /*Set default values */
            int dormCost = 0;
            int mealCost = 0;
            string dormName = "a dorm";
            string mealName = "a meal";

            /*re-populate dorm variables */
            if (Allen.IsChecked == true)
            {
                dormCost = 1500;
                dormName = "Allen Hall";
            }

            else if (Pike.IsChecked == true)
            {
                dormCost = 1600;
                dormName = "Pike Hall";
            }

            else if (Farthing.IsChecked == true)
            {
                dormCost = 1800;
                dormName = "Farthing Hall";
            }

            else if (Suites.IsChecked == true)
            {
                dormCost = 2500;
                dormName = "University Suites";
            }


            /*re-populate meal plan variables */
            if (seven.IsChecked == true)
            {
                mealCost = 600;
                mealName = "7 meals per week";
            }

            else if (fourteen.IsChecked == true)
            {
                mealCost = 1200;
                mealName = "14 meals per week";
            }

            else if (unlimited.IsChecked == true)
            {
                mealCost = 1700;
                mealName = "Unlimited meals";
            }


            /*if both dorm and meal plan values are filled in, pop up new window with calculated values*/
            if ((dormCost != 0) && (mealCost != 0))
            {
                sw.Show();

                int totalCost = dormCost + mealCost;

                sw.DormLabel.Content = string.Format("Dormitory: {0}, ${1}", dormName, dormCost);
                sw.MealLabel.Content = string.Format("Meal plan: {0}, ${1}", mealName, mealCost);
                sw.CostLabel.Content = string.Format("Total cost: ${0}", totalCost);
            }

            /*if dorm and/or meal plan values are missing, error message box */
            else
            {
                MessageBox.Show("Please choose a dormitory and a meal plan");
                sw.Close();
            } 
        }
    }
}
