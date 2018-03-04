using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CajuBio.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewListaUsuario : ContentPage
	{
		public ViewListaUsuario ()
		{
			InitializeComponent ();
		}

        void OnViewUsuario()
        {
            Navigation.PushAsync(new ViewUsuario());
        }
    }
}