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
	public partial class ViewMainMenu : ContentPage
	{
		public ViewMainMenu ()
		{
			InitializeComponent ();
            BindingContext = new ViewModelMainMenu();
            ((ViewModelMainMenu)BindingContext).Navigation = this.Navigation;
        }
        

    }
}