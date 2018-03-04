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
	public partial class ViewMainMenu : ContentPage
	{
		public ViewMainMenu ()
		{
			InitializeComponent ();
		}

        void OnViewGuia()
        {
            Navigation.PushAsync(new ViewGuia());
        }

        void OnViewGestaoMenu()
        {
            Navigation.PushAsync(new ViewGestaoMenu());
        }

    }
}