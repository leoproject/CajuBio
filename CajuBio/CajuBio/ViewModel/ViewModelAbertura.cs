using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using CajuBio.View;
using System.Diagnostics;

namespace CajuBio.ViewModel
{
    class ViewModelAbertura
    {
        public INavigation Navigation { get; set; }
        public ICommand efetuarLoginCommand { get; set; }
        public ICommand efetuarCadastroUsuarioCommand { get; set; }

        public ViewModelAbertura()
        {
            efetuarLoginCommand = new Command(efetuarLogin);
            efetuarCadastroUsuarioCommand = new Command(efetuarCadastroUsuario);

        }

        void efetuarLogin()
        {
            Navigation.PushAsync(new ViewLogin());
        }

        void efetuarCadastroUsuario()
        {
            Navigation.PushAsync(new ViewUsuario());
        }
    }
}
