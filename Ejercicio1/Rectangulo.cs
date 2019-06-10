using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Ejercicio1
{
    class Rectangulo:INotifyPropertyChanged
    {
        //Variables
        private string coordenadaX1;
        private string coordenadaX2;
        private string coordenadaY1;
        private string coordenadaY2;
        private string resultado;

        public string CoordenadaX1
        {
            get
            {
                return coordenadaX1;
            }
            set
            {
                double x1;
                bool resultado = double.TryParse(value, out x1);
                if (resultado) coordenadaX1 = value;
                OnPropertyChanged("CoordenadaX1");
                OnPropertyChanged("Resultado");

            }
        }
        public string CoordenadaX2
        {
            get
            {
                return coordenadaX2;
            }
            set
            {
                int x2;
                bool resultado = int.TryParse(value, out x2);
                if (resultado) coordenadaX2 = value;
                OnPropertyChanged("CoordenadaX2");
                OnPropertyChanged("Resultado");
            }
        }
        public string CoordenadaY1
        {
            get
            {
                return coordenadaY1;
            }
            set
            {
                double y1;
                bool resultado = double.TryParse(value, out y1);
                if (resultado) coordenadaY1 = value;
                OnPropertyChanged("CoordenadaY1");
                OnPropertyChanged("Resultado");
            }
        }
        public string CoordenadaY2
        {
            get
            {
                return coordenadaY2;
            }
            set
            {
                double y2;
                bool resultado = double.TryParse(value, out y2);
                if (resultado)coordenadaY2 = value;
                OnPropertyChanged("CoordenadaY2");
                OnPropertyChanged("Resultado");
            }
        }
        public string Resultado
        {
            get
            {
                double resultadoa = double.Parse(CoordenadaX2) - double.Parse(CoordenadaX1);
                double resultadob = double.Parse(CoordenadaY2) - double.Parse(CoordenadaY1);
                double elevar = Math.Pow(resultadoa, 2);
                double elevarb = Math.Pow(resultadob, 2);
                double resultador = elevar + elevarb;
                double resultado = Math.Sqrt(resultador);
                return resultado.ToString();
            }
            set
            {
                double distanciaa = double.Parse(CoordenadaX2) - double.Parse(CoordenadaX1);
                double distanciab = double.Parse(CoordenadaY2) -double.Parse(CoordenadaY1);
                double da = Math.Pow(distanciaa, 2);
                double db = Math.Pow(distanciab, 2);
                double resultadox = da + db;
                double resultadoxx = Math.Sqrt(resultadox);
                resultado = resultadoxx.ToString();
                OnPropertyChanged("Resultado");

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

    }
}
