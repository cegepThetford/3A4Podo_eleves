using Podo_Affaires;
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

namespace Podo_UI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Podometre _podo;

        public MainWindow()
        {
            InitializeComponent();
            _podo = new Podometre();
        }

        private void BtnIncrementer_Click(object sender, RoutedEventArgs e)
        {
            _podo.incrementer();
            tbValeur.Text = Convert.ToString(_podo.Valeur);
        }

        private void BtnDecrementer_Click(object sender, RoutedEventArgs e)
        {
            _podo.decrementer();
            tbValeur.Text = Convert.ToString(_podo.Valeur);
        }

        private void BtnRaz_Click(object sender, RoutedEventArgs e)
        {
            _podo.raz();
            tbValeur.Text = "0";
        }
    }
}
