using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Phoneword
{
    public partial class MainPage : ContentPage
    {        
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnCall(object sender, System.EventArgs e)
        {
            if (await this.DisplayAlert(
                "Dial a Number",
                "Would you like to call " + phoneNumberText.Text + "?",
                "Yes",
                "No"))
            {

                var dialer = DependencyService.Get<IDialer>();
                if (dialer != null)
                {
                    await dialer.DialAsync(phoneNumberText.Text);
                }

            }

        }

        public interface IDialer
        {
            Task<bool> DialAsync(string number);
        }
        
    }
}
