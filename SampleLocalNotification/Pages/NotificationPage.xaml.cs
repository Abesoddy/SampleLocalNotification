using System;
using Xamarin.Forms;

namespace SampleLocalNotification.Pages
{
    public partial class NotificationPage : ContentPage
    {
        public NotificationPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.GoToMainPage();
        }
    }
}
