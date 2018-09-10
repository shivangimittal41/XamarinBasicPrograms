using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JBasics
{
	public partial class MainPage : ContentPage
	{
        float result;
		public MainPage()
		{
			InitializeComponent();
		}

        private void TotalButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Apple.Text) || string.IsNullOrEmpty(Bananas.Text) || string.IsNullOrEmpty(Oranges.Text)) 
            {
                DisplayAlert("Empty Fields", "Fill all the Fields", "Ok");
            }
            else
            {
                 result = Convert.ToUInt32(Apple.Text) + Convert.ToUInt32(Bananas.Text) + Convert.ToUInt32(Oranges.Text);
            }
            Total.Text = Convert.ToString(result);
        }
        private void Clear_Clicked(object sender, EventArgs e)
        {
            Apple.Text = " ";
            Bananas.Text = " ";
            Oranges.Text = " ";
            Total.Text = " ";
        }
    }
}
