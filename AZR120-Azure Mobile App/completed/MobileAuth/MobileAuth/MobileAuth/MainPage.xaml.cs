using System;
using Xamarin.Forms;

namespace MobileAuth
{
    public partial class MainPage : ContentPage
    {
        //인증 여부용 bool 변수
        bool authenticated = false;

        public MainPage()
        {
            InitializeComponent();
        }

        async void loginButton_Clicked(object sender, EventArgs e)
        {
            if (App.Authenticator != null)
                authenticated = await App.Authenticator.Authenticate();

            if (authenticated == true)
                authLabel.Text = "인증 되었습니다";
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (authenticated == true)
            {
                authLabel.Text = "인증 되었습니다";
                this.loginButton.IsVisible = false;
            }
        }
    }
}
