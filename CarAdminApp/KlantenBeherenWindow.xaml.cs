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

namespace CarAdminApp
{
    public partial class KlantenBeherenWindow : Window
    {
        public KlantenBeherenWindow()
        {
            InitializeComponent();
        }

        private void KlantToevoegen_Click(object sender, RoutedEventArgs e)
        {
            string klantNaam = KlantNaamTextBox.Text;


            MessageBox.Show($"Klant toegevoegd: {klantNaam}");
            this.Close();
        }

        private void Sluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
