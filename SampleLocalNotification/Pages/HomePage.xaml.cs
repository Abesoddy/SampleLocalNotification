using System;
using System.Collections.Generic;
using System.ComponentModel;
using SampleLocalNotification.Pages;
using Plugin.LocalNotification;
using Xamarin.Forms;

namespace SampleLocalNotification
{
    [DesignTimeVisible(true)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void NotificationButtonClicked(object sender, EventArgs e)
        {
            var list = new List<string>
            {
                typeof(NotificationPage).FullName,
                //_tapCount.ToString()
            };

            var serializeReturningData = ObjectSerializer<List<string>>.SerializeObject(list);

            var notifyDateTime = DateTime.Now.AddSeconds(15);

            var notification = new NotificationRequest
            {
                NotificationId = 100,
                Title = "Test",
                Description = $"Tap Count",
                BadgeNumber = 1,
                ReturningData = serializeReturningData,
                NotifyTime = notifyDateTime
            };

            NotificationCenter.Current.Show(notification);
        }
    }
}