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

namespace WpfControlsTextApp
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

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock txt = sender as TextBlock;
            txt.Foreground = Brushes.Red;
        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock txt = sender as TextBlock;
            txt.Foreground = Brushes.Black;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string msg = "Start: " + txtName.SelectionStart.ToString();
            msg += " Length: " + txtName.SelectionLength.ToString();
            msg += "\n\n" + txtName.SelectedText;
            MessageBox.Show(msg);
        }
    }
}
