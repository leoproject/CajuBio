using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CajuBio.ViewModel;

namespace CajuBio.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewGuia : ContentPage
	{
		public ViewGuia ()
		{
			InitializeComponent ();
            BindingContext = new ViewModelGuia();
            ((ViewModelGuia)BindingContext).Navigation = this.Navigation;
        }

        public ViewGuia(int idPai)
        {
            InitializeComponent();
            BindingContext = new ViewModelGuia(idPai);
            ((ViewModelGuia)BindingContext).Navigation = this.Navigation;
        }
    }
}