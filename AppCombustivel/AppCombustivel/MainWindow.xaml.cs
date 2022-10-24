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

namespace AppCombustivel
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

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            Abastecimento obj = new Abastecimento();
            obj.SetKmRodado(double.Parse(txtKmRodado.Text));
            obj.SetValorLitro(double.Parse(txtValorLitro.Text));
            obj.SetValorPago(double.Parse(txtValorPago.Text));
            txtKmLitro.Text = obj.MediaKmLitro().ToString("0.00");
            txtRListro.Text = obj.MediaReaisKm().ToString("0.00");
        }
    }
}
