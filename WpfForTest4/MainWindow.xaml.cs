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

namespace WpfForTest4
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

        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            this.StateString.Text = ((MenuItem)sender).Header.ToString();
        }

        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            this.StateString.Text = "";
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((MenuItem)sender).Header.ToString());
        }
        private void Solid_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (var child in LogicalTreeHelper.GetChildren(this.Body))
            {
                if (child is Border border)
                {
                    border.Resources["InnerSolid"] = this.TryFindResource("InnerSolid");
                }
            }
        }
        private void Gradient_Click(object sender, RoutedEventArgs e)
        {
            foreach (var child in LogicalTreeHelper.GetChildren(this.Body))
            {
                if (child is Border border)
                {
                    border.Resources["InnerSolid"] = this.TryFindResource("InnerGradient");
                }
            }
        }
        
    }
}
