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

namespace IntroduccionWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {

            InitializeComponent();

            //Aparece estos nombres como base
            JuntaNombreYApellido = new JuntaNombre { Nombre = "Juan", Apellido = "Diaz" };
            //Indica el origen de los datos indicando los del nombre y apellido
            this.DataContext = JuntaNombreYApellido;
        }

        private JuntaNombre JuntaNombreYApellido;

    }

}

