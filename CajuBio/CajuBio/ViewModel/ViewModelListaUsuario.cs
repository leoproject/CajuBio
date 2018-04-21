using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using CajuBio.View;
using CajuBio.Model;
using CajuBio.Requester;
using System.ComponentModel;

namespace CajuBio.ViewModel
{
    public class ViewModelListaUsuario : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        List<Usuario> usuarios;

        public List<Usuario> Usuarios
        {
            set
            {
                usuarios = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Usuarios"));
                }
            }
            get
            {
                return usuarios;
            }
        }

        public INavigation Navigation { get; set; }
        public ICommand atulizarCommand { get; set; }
        public ICommand deletarComamand { get; set; }
        public ICommand buscarCommand { get; set; }

        public ViewModelListaUsuario()
        {
            buscarCommand = new Command(buscar);
        }

        void buscar()
        {
            Usuarios = FacadeRequester.Instance.readAllUsuario();

            //Navigation.PushAsync(new ViewEditarUsuario());
        }


    }
}
