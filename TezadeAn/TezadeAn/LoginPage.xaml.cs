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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateAcountPage());
        }
        private async void Button_OnClick(object sender, EventArgs e)
        {
            var email = EntryMail.Text;

            var emailPattern = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";

            if (!String.IsNullOrWhiteSpace(email) && !(Regex.IsMatch(email, emailPattern)))
            {
                LabelError.Text = "Email or Password incorect";

            }
            else
            {
                await Navigation.PushAsync(new CreateAcountPage());

                //await DisplayAlert("Error", "Sorry,but at the moment server doesn't work", "OK");

            }
        }

}
}
