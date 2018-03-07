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
	public partial class ViewItemGuia : ContentPage
	{
		public ViewItemGuia ()
		{
			InitializeComponent ();
            BindingContext = new ViewModelItemGuia();
		}

        public ViewItemGuia(int idpai)
        {
            InitializeComponent();
            BindingContext = new ViewModelItemGuia(idpai);
        }
    }
}