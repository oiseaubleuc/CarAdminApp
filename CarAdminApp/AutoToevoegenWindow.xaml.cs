using CarAdminApp.Models;
using CarAdminApp.Services;
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
    public partial class AutoToevoegenWindow : Window
    {
        private AutoService autoService;

        public AutoToevoegenWindow()
        {
            InitializeComponent();
            autoService = new AutoService();
        }

        private void VoegAutoToe_Click(object sender, RoutedEventArgs e)
        {
            string merk = MerkTextBox.Text;
            string model = ModelTextBox.Text;
            decimal prijs = decimal.Parse(PrijsTextBox.Text);

            Auto nieuweAuto = new Auto(merk, model, prijs);
            autoService.VoegAutoToe(nieuweAuto);
            MessageBox.Show("Auto toegevoegd!");
        }
    }
}