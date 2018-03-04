using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using CajuBio.View;

namespace CajuBio.ViewModel
{
    public class ViewModelGuia
    {
        public INavigation Navigation { get; set; }
        public ICommand itemSelecionadoCommand { get; set; }

        public ViewModelGuia()
        {
            itemSelecionadoCommand = new Command(itemSelecionado); 
        }

        void itemSelecionado()
        {
            Navigation.PushAsync(new ViewItemGuia());
        }
    }
}
