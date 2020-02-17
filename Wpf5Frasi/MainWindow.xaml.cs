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

namespace Wpf5Frasi
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
        string[] frasi = new string[5];
        int z = 0;

        private void BtnInserisci_Click(object sender, RoutedEventArgs e)
        {
            frasi[z] = TxtFrasi.Text;
            z++;
            BtnInserisci.IsEnabled = true;
            TxtFrasi.Clear();
            TxtFrasi.Focus();
            if(z >= 5)
            {
                BtnInserisci.IsEnabled = false;
            }
        }
    }
}
