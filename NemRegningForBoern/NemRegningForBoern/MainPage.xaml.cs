using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NemRegningForBoern
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		    PickerType.SelectedIndex = 0;
		    PickerDifficulty.SelectedIndex = 1;
		    PickerNoOfAnswers.SelectedIndex = 1;

            BtnStart.Clicked += BtnStart_Clicked;
		}

        private void BtnStart_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Test", "Skal stadig implementeres!", "OK");
        }

	}
}
