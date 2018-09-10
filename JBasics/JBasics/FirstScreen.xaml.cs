using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JBasics
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FirstScreen : ContentPage
	{
		public FirstScreen ()
		{
			InitializeComponent ();
		}

        private void TotalFruits_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync( new MainPage());
        }

        private void WrappedText_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WrappedText());

        }

        private void CalcButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calculator());
        }

        private void SIButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SI());
        }

        private void AreaButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AreaCalc());
        }
    }
}