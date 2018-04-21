using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using CajuBio.View;

namespace CajuBio.ViewModel
{
    public class ViewModelMainMenu
    {
        public INavigation Navigation { get; set; }
        public ICommand consultarGuiasCommand { get; set; }
        public ICommand gestaoInformacaoComamnd { get; set; }

        public ViewModelMainMenu()
        {
            consultarGuiasCommand = new Command(consultarGuias);
            gestaoInformacaoComamnd = new Command(gestaoInformacao);
        }

        void consultarGuias()
        {
            Navigation.PushAsync(new ViewGuia(0));
        }

        void gestaoInformacao()
        {
            Navigation.PushAsync(new ViewGestaoMenu());
        }
    }
}
