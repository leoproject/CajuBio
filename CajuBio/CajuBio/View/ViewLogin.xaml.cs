﻿using System;
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
	public partial class ViewLogin : ContentPage
	{
		public ViewLogin ()
		{
			InitializeComponent ();
            BindingContext = new ViewModelLogin();
            ((ViewModelLogin)BindingContext).Navigation = this.Navigation;
        }
	}
}