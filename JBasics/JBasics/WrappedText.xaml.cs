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
	public partial class WrappedText : ContentPage
	{
        
		public WrappedText ()
		{
			InitializeComponent ();
		}

        private void StarButton_Clicked(object sender, EventArgs e)
        {
            AlteredText.Text = "*" + UserText.Text + "*";
        }
        private void HashButton_Clicked(object sender, EventArgs e)
        {
            AlteredText.Text = "#" + UserText.Text + "#";
        }
        private void PercentButton_Clicked(object sender, EventArgs e)
        {
            AlteredText.Text = "%" + UserText.Text + "%";
        }
        private void DoubleQButton_Clicked(object sender, EventArgs e)
        {
            AlteredText.Text = "\"" + UserText.Text + "\"";
        }
        private void StopButton_Clicked(object sender, EventArgs e)
        {
            AlteredText.Text = " ";
            UserText.Text = " ";
        }
    }

}