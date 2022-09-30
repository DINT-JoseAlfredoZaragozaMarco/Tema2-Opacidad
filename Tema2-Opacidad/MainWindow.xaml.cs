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
            if(imagen1.IsMouseOver)
            {
                imagen1.Opacity = 1;
            }
            else
            {
                imagen1.Opacity = 0.5;
            }
            if (imagen2.IsMouseOver)
            {
                imagen2.Opacity = 1;
            }
            else
            {
                imagen2.Opacity = 0.5;
            }
            if (imagen3.IsMouseOver)
            {
                imagen3.Opacity = 1;
            }
            else
            {
                imagen3.Opacity = 0.5;
            }
        }
    }
}
