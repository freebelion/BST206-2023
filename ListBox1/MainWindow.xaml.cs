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

namespace ListBox1
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ListBox3Yukle();
            ListBox4Yukle();
            ListBox5Yukle();
        }

        private void ListBox3Yukle()
        {
            listbox3.Items.Add("Recai");
            listbox3.Items.Add("Sezai");
            listbox3.Items.Add("Mesai");
            listbox3.Items.Add("Masai");
            listbox3.Items.Add("Kasai");
        }

        private void ListBox4Yukle()
        {
            List<string> elemanlar =
                new List<string>() { "Recai", "Sezai", "Mesai", "Envai", "Rubai"};

            listbox4.ItemsSource = elemanlar;
        }

        private void ListBox5Yukle()
        {
            listbox5.Items.Add("Images/elma.png");
            listbox5.Items.Add("Images/kayisi.png");
            listbox5.Items.Add("Images/lahana.png");
            listbox5.Items.Add("Images/muz.png");
            listbox5.Items.Add("Images/ananas.png");
        }
    }
}
