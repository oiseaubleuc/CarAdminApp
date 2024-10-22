using System;
using System.Windows;

namespace CarAdminApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AutoToevoegen_Click(object sender, RoutedEventArgs e)
        {
            AutoToevoegenWindow venster = new AutoToevoegenWindow();
            venster.Show();
        }

        private void AutosBekijken_Click(object sender, RoutedEventArgs e)
        {
            AutosBekijkenWindow venster = new AutosBekijkenWindow();
            venster.Show();
        }

        private void KlantenBeheren_Click(object sender, RoutedEventArgs e)
        {
            KlantenBeherenWindow venster = new KlantenBeherenWindow();
            venster.Show();
        }

        private void BetalingenBeheren_Click(object sender, RoutedEventArgs e)
        {
            BetalingenBeherenWindow venster = new BetalingenBeherenWindow();
            venster.Show();
        }


    }
}
