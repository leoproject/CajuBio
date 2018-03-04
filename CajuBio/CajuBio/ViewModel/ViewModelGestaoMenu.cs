using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using CajuBio.View;

namespace CajuBio.ViewModel
{
    public class ViewModelGestaoMenu
    {
        public INavigation Navigation { get; set; }
        public ICommand gerarRelatorioCommand { get; set; }
        public ICommand administrarUsuariosCommand { get; set; }
        public ICommand administrarGuiasCommand { get; set; }

        public ViewModelGestaoMenu()
        {
            gerarRelatorioCommand = new Command(gerarRelatorio);
            administrarUsuariosCommand = new Command(administrarUsuarios);
            administrarGuiasCommand = new Command(administrarGuias);


        }

        void gerarRelatorio()
        {
            Navigation.PushAsync(new ViewIndicadorAcesso());
        }

        void administrarUsuarios()
        {
            Navigation.PushAsync(new ViewListaUsuario());
        }

        void administrarGuias()
        {
            Navigation.PushAsync(new ViewGuia());
        }
    }
}
