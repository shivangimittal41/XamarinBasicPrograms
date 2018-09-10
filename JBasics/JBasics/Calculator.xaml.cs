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
	public partial class Calculator : ContentPage
	{
		public Calculator ()
		{
			InitializeComponent ();
		}

        private void PlusButton_Clicked(object sender, EventArgs e)
        {
            var res = Convert.ToUInt32(FirstNum.Text) + Convert.ToUInt32(SecondNum.Text);
            result.Text = Convert.ToString(res);
        }
        private void MinusButton_Clicked(object sender, EventArgs e)
        {
            var res = Convert.ToUInt32(FirstNum.Text) - Convert.ToUInt32(SecondNum.Text);
            result.Text = Convert.ToString(res);
        }
        private void MulButton_Clicked(object sender, EventArgs e)
        {
            var res = Convert.ToUInt32(FirstNum.Text) * Convert.ToUInt32(SecondNum.Text);
            result.Text = Convert.ToString(res);
        }
        private void DivButton_Clicked(object sender, EventArgs e)
        {
            var res = Convert.ToUInt32(FirstNum.Text) / Convert.ToUInt32(SecondNum.Text);
            result.Text = Convert.ToString(res);
        }
        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            result.Text = " ";
            FirstNum.Text = " ";
            SecondNum.Text = " ";
        }
        private void StopButton_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Stop Pressed")
            Navigation.PopToRootAsync();
        }
    }
}