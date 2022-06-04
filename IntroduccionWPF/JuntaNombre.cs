using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionWPF
{
    //INotifyPropertyChanged sirve para que cuando un objeto modifique una propiedad cualquiera este desencadenen una accion
    //Reune todo los enemtos que desencadena un objeto en uno solo
    //se llama a la interfaz INotiy...
    class JuntaNombre:INotifyPropertyChanged
    {

        //Se indica los nombres
        private string nombre, apellido, nombre_Completo;
        //El eventHandler es el que controlara property changed, este sera la guia para el eventArgs
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {//este tiene lugar cuando se cambia una propiedad
            //cuando sera difererente de null
            if (PropertyChanged != null)
            {//dira que evento se desencadena en el string de property, a traves de un valor string
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public string Nombre
        {
            get{ return nombre; }
            set{ nombre = value;

                OnPropertyChanged("Nombre_Completo"); }
        }

        public string Apellido
        {
            get{ return apellido; }
            set
            {
                apellido = value;
                //Hace que el valor se reprensente en el campo nombrado en este caso es Nombre_Completo
                OnPropertyChanged("Nombre_Completo");
            }
        }

        public string Nombre_Completo
        {
            get{  nombre_Completo = nombre + " " + apellido;
                return nombre_Completo;
            }
            set {  }

        }


    }
}
