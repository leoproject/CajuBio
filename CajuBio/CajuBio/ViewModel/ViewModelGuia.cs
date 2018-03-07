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
    public class ViewModelGuia : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        List<Guia> _guias;

        public List<Guia> Guias
        {
            set
            {
                _guias = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Guias"));
                }
            }
            get
            {
                return _guias;
            }
        }

        Guia _guia;
        public Guia Guia
        {
            get
            {
                return _guia;
            }

            set
            {
                _guia = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Guia"));
                itemSelecionado();
            }
        }


        public INavigation Navigation { get; set; }
        public ICommand itemSelecionadoCommand { get; set; }

        public ViewModelGuia()
        {
            itemSelecionadoCommand = new Command(itemSelecionado); 
        }

        public ViewModelGuia(int idPai)
        {
            Guias = FacadeRequester.Instance.readGuiaChildsOf(idPai);
            itemSelecionadoCommand = new Command(itemSelecionado);
        }

        void itemSelecionado()
        {
            List<Guia> armengo = FacadeRequester.Instance.readGuiaChildsOf(Guia.id);
            if (armengo.Count > 0)
            {
                Navigation.PushAsync(new ViewGuia(Guia.id));
            } else
            {
                Navigation.PushAsync(new ViewItemGuia(Guia.id));
            }
        }
    }
}
