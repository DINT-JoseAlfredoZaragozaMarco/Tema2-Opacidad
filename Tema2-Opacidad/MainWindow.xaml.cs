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

namespace Tema2_Opacidad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            imagen1.Opacity = 0.5;
            imagen2.Opacity = 0.5;
            imagen3.Opacity = 0.5;
        }

        private void IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if((sender as Image).IsMouseOver) (sender as Image).Opacity = 1;
            else (sender as Image).Opacity = 0.5;
        }
    }
}
