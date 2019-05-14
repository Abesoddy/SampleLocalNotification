using System.Collections.Generic;
using SampleLocalNotification.Pages;
using Plugin.LocalNotification;
using Xamarin.Forms;

namespace SampleLocalNotification
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Local Notification tap event listener
            NotificationCenter.Current.NotificationTapped += LoadPageFromNotification;

            // Init main page
            GoToMainPage();
        }

        public void GoToMainPage()
        {
            MainPage = new HomePage();
        }

        public new static App Current => Application.Current as App;

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void LoadPageFromNotification(NotificationTappedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.Data))
            {
                return;
            }

            var list = ObjectSerializer<List<string>>.DeserializeObject(e.Data);
            //if (list.Count != 2)
            //{
            //    return;
            //}
            if (list[0] != typeof(NotificationPage).FullName)
            {
                return;
            }
            //var tapCount = list[1];

            MainPage = new NotificationPage();
        }
    }
}
