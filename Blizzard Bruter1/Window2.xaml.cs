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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.ShowInTaskbar = false;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboboxProxy.SelectedIndex == 0)
            {
                Properties.Settings.Default.proxytype = 1;
                Properties.Settings.Default.Save();
            }
            else if(comboboxProxy.SelectedIndex == 1)
            {
                Properties.Settings.Default.proxytype = 2;
                Properties.Settings.Default.Save();
            }
            else if(comboboxProxy.SelectedIndex == 2)
            {
                Properties.Settings.Default.proxytype = 3;
                Properties.Settings.Default.Save();
            }
        }

        private void sliderThread_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblThread.Content = "Thread: " + sliderThread.Value.ToString();
            Properties.Settings.Default.Thread = (int)sliderThread.Value;
            Properties.Settings.Default.Save();
        }
    }
}
