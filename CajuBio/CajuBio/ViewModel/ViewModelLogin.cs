using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using CajuBio.View;
using CajuBio.Requester;
using System.Threading.Tasks;
using CajuBio.Model;

namespace CajuBio.ViewModel
{
   public class ViewModelLogin
    {
        public INavigation Navigation { get; set; }
        public ICommand efetuarAcessoCommand { get; set; }

        public ViewModelLogin()
        {
            efetuarAcessoCommand = new Command(efetuarAcesso);
          

        }

       async void efetuarAcesso()
        {
            UsuarioRequester requester = new UsuarioRequester();
            Usuario usuario = request.readAsync("jecrjunior@dcomp.ufs.br", "");
            Navigation.PushAsync(new ViewMainMenu());

        }
    }
}
