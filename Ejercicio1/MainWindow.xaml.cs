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

namespace Ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rectangulo Rec
        {
            get;set;
        }
        public MainWindow()
        {
            InitializeComponent();
            Rec = new Rectangulo
            {
                CoordenadaX1 = "1",
                CoordenadaX2 = "2",
                CoordenadaY1 = "3",
                CoordenadaY2 = "4",
                Resultado = "Resultado de coordenadas"

            };
            this.DataContext = Rec;
        }
    }
}
