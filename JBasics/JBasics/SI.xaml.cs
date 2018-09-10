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
	public partial class SI : ContentPage
	{
		public SI ()
		{
			InitializeComponent ();
		}

        private void SICalcButton_Clicked(object sender, EventArgs e)
        {
            var res = Convert.ToUInt32(Principal.Text) * Convert.ToUInt32(Rate.Text) * Convert.ToUInt32(Time.Text);
            var SI = res / 100;
            result.Text = Convert.ToString(SI);
        }
        private void StopButton_Clicked(object sender, EventArgs e)
        {
            Principal.Text = " ";
            Rate.Text = " ";
            Time.Text = " ";
            result.Text = " ";
        }
    }
}