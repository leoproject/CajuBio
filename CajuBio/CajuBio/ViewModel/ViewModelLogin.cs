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
   public class ViewModelLogin:NotificaBase
    {
        public INavigation Navigation { get; set; }
        public ICommand efetuarAcessoCommand { get; set; }

        // Dados inseridos na ViewLogin
        public string email { get; set; }
        public string senha { get; set; }
        private string _result;
        public string RESULTADO
        {
            get { return _result; }
            set
            {
                _result = value;
                Notificar();
            }
        }


        public ViewModelLogin()
        {
            efetuarAcessoCommand = new Command(efetuarAcesso);
          

        }

        void efetuarAcesso()
        {
            UsuarioRequester requester = new UsuarioRequester();
            
            string usuario = requester.read("jecrjunior@dcomp.ufs.br", senha);
            RESULTADO = usuario;

            //Navigation.PushAsync(new ViewMainMenu());

        }
    }
}
