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
using System.Windows.Threading;
using System.Collections.ObjectModel;

namespace Binding1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rnd = new Random();
        private DispatcherTimer zamanlayici = new DispatcherTimer();
        public ObservableCollection<int> Sayilar { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            zamanlayici.Interval = TimeSpan.FromSeconds(5);
            zamanlayici.Tick += Zamanlayici_Tick;

            Sayilar = new ObservableCollection<int>();
            SayilarOlustur();

            zamanlayici.Start();
        }

        private void Zamanlayici_Tick(object? sender, EventArgs e)
        {
            Sayilar.Clear();
            SayilarOlustur();
        }

        private void SayilarOlustur()
        {
            for(int i=0, n = rnd.Next(5,16); i < n; i++)
            {
                Sayilar.Add(rnd.Next(10,100));
            }
        }
    }
}
