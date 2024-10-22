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
    public partial class AutosBekijkenWindow : Window
    {
        public AutosBekijkenWindow()
        {
            InitializeComponent();
            // Hier zou je code toevoegen om de lijst met auto's dynamisch in te vullen
        }

        private void Sluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
