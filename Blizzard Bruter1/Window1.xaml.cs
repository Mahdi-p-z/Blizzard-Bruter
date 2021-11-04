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

namespace Blizzard_Bruter1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public bool ico;

        public Window1()
        {
            InitializeComponent();
        }

        private void checkboxTask_Checked(object sender, RoutedEventArgs e)
        {
            checkboxTray.IsChecked = false;
        }

        private void checkboxTask_Unchecked(object sender, RoutedEventArgs e)
        {
            checkboxTray.IsChecked = true;
        }

        private void checkboxTray_Unchecked(object sender, RoutedEventArgs e)
        {
            checkboxTask.IsChecked = true;
        }

        private void checkboxTray_Checked(object sender, RoutedEventArgs e)
        {
            checkboxTask.IsChecked = false;
        }

        private void btnMini_Click(object sender, RoutedEventArgs e)
        {
            if (checkboxTask.IsChecked == true && checkboxTray.IsChecked == false)
            {
                this.Close();
                //new Tra() { Tray = false };
                ico = false;
                Properties.Settings.Default.Icon = false;
                Properties.Settings.Default.Save();
            }
            else if (checkboxTray.IsChecked == true && checkboxTask.IsChecked == false)
            {
                this.Close();
                //new Tra() { Tray = true };
                ico = true;
                Properties.Settings.Default.Icon = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Please Select Software Location.");
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Topmost = true;
        }
    }
}
