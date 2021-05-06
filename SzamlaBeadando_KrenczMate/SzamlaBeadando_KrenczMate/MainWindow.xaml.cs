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

namespace SzamlaBeadando_KrenczMate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Szamla 1 példány
        /// </summary>
        static Szamla szamla1;

        /// <summary>
        /// Szamla 2 példány
        /// </summary>
        static Szamla szamla2;


        public MainWindow()
        {
            InitializeComponent();
            
            szamla1 = new Szamla(2500, "Beta");
            szamla2 = new Szamla(3500, "Alfa");
            
            Egyenleg1.Text = Convert.ToString(szamla1.Egyenleg);
            Egyenleg2.Text = Convert.ToString(szamla2.Egyenleg);
            Tulaj1.Text = szamla1.Tulajdonos;
            Tulaj2.Text = szamla2.Tulajdonos;
        }

        /// <summary>
        /// Szamla1 feltöltő gombjának metódusa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fel1_Click(object sender, RoutedEventArgs e)
        {
            szamla1.Feltolt(Be1.Text);
            Egyenleg1.Text = Convert.ToString(szamla1.Egyenleg);
        }

        /// <summary>
        /// Szamla2 feltöltő gombjának metódusa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fel2_Click(object sender, RoutedEventArgs e)
        {
            szamla2.Feltolt(Be2.Text);
            Egyenleg2.Text = Convert.ToString(szamla2.Egyenleg);
        }

        /// <summary>
        /// Szamla1 utaló gombjának metódusa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Utal1_Click(object sender, RoutedEventArgs e)
        {
            szamla1.Utalas(Be1.Text, szamla2);
            Egyenleg1.Text = Convert.ToString(szamla1.Egyenleg);
            Egyenleg2.Text = Convert.ToString(szamla2.Egyenleg);
        }
        /// <summary>
        /// Szamla2 utaló gombjának metódusa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Utal2_Click(object sender, RoutedEventArgs e)
        {
            szamla2.Utalas(Be2.Text, szamla1);
            Egyenleg1.Text = Convert.ToString(szamla1.Egyenleg);
            Egyenleg2.Text = Convert.ToString(szamla2.Egyenleg);
        }

        /// <summary>
        /// Szamla1 pénz kivevő gombjának metódusa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Kivesz1_Click(object sender, RoutedEventArgs e)
        {
            szamla1.Kivet(Be1.Text);
            Egyenleg1.Text = Convert.ToString(szamla1.Egyenleg);
        }
        /// <summary>
        /// Szamla2 pénz kivevő gombjának metódusa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Kivesz2_Click(object sender, RoutedEventArgs e)
        {
            szamla2.Kivet(Be2.Text);
            Egyenleg2.Text = Convert.ToString(szamla2.Egyenleg);
        }

        /// <summary>
        /// Szamla1 tulajdonosát megváltoztató gomb metódusa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nev1_Click(object sender, RoutedEventArgs e)
        {
            szamla1.Tulajdonos = Be1.Text;
            Tulaj1.Text = szamla1.Tulajdonos;
        }

        /// <summary>
        /// Szamla2 tulajdonosát megváltoztató gomb metódusa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nev2_Click(object sender, RoutedEventArgs e)
        {
            szamla2.Tulajdonos = Be2.Text;
            Tulaj2.Text = szamla2.Tulajdonos;
        }
    }
}
