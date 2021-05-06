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

namespace SzamlaBeadando_KrenczMate
{
    /// <summary>
    /// Interaction logic for Hiba.xaml
    /// </summary>
    public partial class Hiba : Window
    {

        /// <summary>
        /// A hibát megjelenítő ablak konstruktora
        /// </summary>
        /// <param name="hiba">Az aktuális hibához tartozó üzenet</param>
        public Hiba(string hiba)
        {
            InitializeComponent();
            Uzenet.Text = hiba;
        }
    }
}
