using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CajuBio.ViewModel;

namespace CajuBio.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewIndicadorAcesso : ContentPage
	{
		public ViewIndicadorAcesso ()
		{

            InitializeComponent();
            /*BindingContext = new ViewModelGestaoMenu();
            ((ViewModelGestaoMenu)BindingContext).Navigation = this.Navigation;*/

            Grafico.Chart = new Microcharts.DonutChart() { Entries = entries };
        }
        List<Microcharts.Entry> entries = new List<Microcharts.Entry>
        {
            new Microcharts.Entry(200)
            {
                Label = "Médico Residente",
                ValueLabel = "200",
                Color = SKColor.Parse("#266489")
            },
            new Microcharts.Entry(250)
            {
                Label = "Enfermeiro",
                ValueLabel = "250",
                Color = SKColor.Parse("#68B9C0")
            },
            new Microcharts.Entry(100)
            {
                Label = "Médico Professor",
                ValueLabel = "100",
                Color = SKColor.Parse("#90D585")
            },
            new Microcharts.Entry(150)
            {
                Label = "Enfermeiro",
                ValueLabel = "150",
                Color = SKColor.Parse("#e77e23")
            }
        };
    }
}