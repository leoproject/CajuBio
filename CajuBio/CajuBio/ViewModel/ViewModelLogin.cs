using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using CajuBio.View;

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

        void efetuarAcesso()
        {
            Navigation.PushAsync(new ViewMainMenu());
        }
    }
}
