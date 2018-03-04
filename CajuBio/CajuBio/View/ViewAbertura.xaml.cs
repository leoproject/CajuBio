using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CajuBio.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CajuBio.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewAbertura : ContentPage
	{
	    public ViewAbertura()
        {
            InitializeComponent();
            BindingContext = new ViewModelAbertura();
            ((ViewModelAbertura)BindingContext).Navigation = this.Navigation;
        }
    }
}