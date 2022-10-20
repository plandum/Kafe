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

namespace ZakazVKafe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CBNuggets_Click(object sender, RoutedEventArgs e)
        {
            if (CBNuggets.IsChecked == true) { TxBNuggets.IsEnabled = true; }
            else { TxBNuggets.IsEnabled = false; TxBNuggets.Clear(); }
        }

        private void CBCola_Click(object sender, RoutedEventArgs e)
        {
            if (CBCola.IsChecked == true) { TxBCola.IsEnabled = true; }
            else { TxBCola.IsEnabled = false; TxBCola.Clear(); }
        }

        private void CBGumburger_Click(object sender, RoutedEventArgs e)
        {
            if (CBGumburger.IsChecked == true) { TxBGumburger.IsEnabled = true; }
            else { TxBGumburger.IsEnabled = false; TxBGumburger.Clear(); }
        }

        private void CBCheesburger_Click(object sender, RoutedEventArgs e)
        {
            if (CBCheesburger.IsChecked == true) { TxBCheesburger.IsEnabled = true; }
            else { TxBCheesburger.IsEnabled = false; TxBCheesburger.Clear(); }
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            OrderLB.Items.Clear();
                if (CBCheesburger.IsChecked == true) { OrderLB.Items.Add("Чизбургер в количестве " + TxBCheesburger.Text); }
                if (CBGumburger.IsChecked == true) { OrderLB.Items.Add("Гамбургер в количестве " + TxBGumburger.Text); }
                if (CBCola.IsChecked == true) { OrderLB.Items.Add("Кола в количестве " + TxBCola.Text); }
                if (CBNuggets.IsChecked == true) { OrderLB.Items.Add("Наггетсы в количестве " + TxBNuggets.Text); }
        }
    }
}
