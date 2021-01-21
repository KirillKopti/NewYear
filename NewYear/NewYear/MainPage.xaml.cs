using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewYear
{
    public partial class MainPage : ContentPage
    {
        Random rnd;
        public MainPage()
        {
            InitializeComponent();
        }
        private void sms_btn_Clicked(object sender, EventArgs e)
        {
            var sms = CrossMessaging.Current.SmsMessenger;
            if (sms.CanSendSms)
            {
                sms.SendSms(tel_nr_email.Text, text.Text);
            }
        }

        private void call_btn_Clicked(object sender, EventArgs e)
        {
            var call = CrossMessaging.Current.PhoneDialer;
            if (call.CanMakePhoneCall)
            {
                call.MakePhoneCall(tel_nr_email.Text);
            }
        }

        private void mail_btn_Clicked(object sender, EventArgs e)
        {
            var mail = CrossMessaging.Current.EmailMessenger;
            if (mail.CanSendEmail)
            {
                mail.SendEmail(tel_nr_email.Text, "Tervitus", text.Text);
            }
        }

        private void random_btn_Clicked(object sender, EventArgs e)
        {
            rnd = new Random();
            picker.SelectedIndex = rnd.Next(0, 5);
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            picker.Title = "Путь Джедая " + picker.Items[picker.SelectedIndex];
            if (picker.SelectedIndex == 0)
            {
                text.Text = $"{picker}";
            }

            if (picker.SelectedIndex == 1)
            {
                text.Text = $"{picker}";
            }

            if (picker.SelectedIndex == 2)
            {
                text.Text = $"{picker}";
            }

            if (picker.SelectedIndex == 3)
            {
                text.Text = $"{picker}";
            }

            if (picker.SelectedIndex == 4)
            {
                text.Text = $"{picker}";
            }

            if (picker.SelectedIndex == 5)
            {
                text.Text = $"{picker}";
            }

            if (picker.SelectedIndex == 6)
            {
                text.Text = $"{picker}";
            }
        }
    }
}
