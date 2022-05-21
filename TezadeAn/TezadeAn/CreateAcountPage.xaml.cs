using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TezadeAn
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAcountPage : ContentPage
    {
        public CreateAcountPage()
        {
            InitializeComponent();
        }

        private void Button_OnClick(object sender, EventArgs e)
        {
            var email = EntryMail1.Text;

            var emailPattern = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";

            if (!String.IsNullOrWhiteSpace(email) && !(Regex.IsMatch(email, emailPattern)))
            {
                LabelError.Text = "Email format is incorect";

            }
            else
            {
                LabelError.Text = " ";
            }
        }

        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateAcountPage());
            //await DisplayAlert("Error","Sorry,but at the moment server doesn't work","OK");

        }
    }
}