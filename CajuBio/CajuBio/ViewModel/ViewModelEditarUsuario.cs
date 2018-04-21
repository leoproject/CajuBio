using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using CajuBio.View;
using System.Threading.Tasks;

namespace CajuBio.ViewModel
{
    public class ViewModelEditarUsuario
    {
        public INavigation Navigation { get; set; }
        public ICommand editarCommand { get; set; }
        public ICommand cancelarCommand { get; set; }

        public ViewModelEditarUsuario()
        {
            editarCommand = new Command(editar);
        }

        void editar()
        {
           
            Navigation.PushAsync(new ViewListaUsuario());
        }

       
    }
}
