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

namespace ExamenSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSig_Click(object sender, RoutedEventArgs e)
        {
            ctrlInfoPer.Visibility = Visibility.Collapsed;
            ctrlCont.Visibility = Visibility.Visible;

            btnSig.Visibility = Visibility.Collapsed;
            btnSig2.Visibility = Visibility.Visible;
        }

        private void btnSig2_Click(object sender, RoutedEventArgs e)
        {
            ctrlInfoPer.Visibility = Visibility.Collapsed;
            ctrlCont.Visibility = Visibility.Collapsed;
            ctrlInfoPago.Visibility = Visibility.Visible;

            btnSig.Visibility = Visibility.Collapsed;
            btnSig2.Visibility = Visibility.Collapsed;
            btnFin.Visibility = Visibility.Visible;
        }
    }
}
