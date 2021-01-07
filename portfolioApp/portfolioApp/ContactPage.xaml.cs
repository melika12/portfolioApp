using Plugin.Messaging;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace portfolioApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ContactPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        private void Email(object sender, EventArgs e)
        {
            var email = CrossMessaging.Current.EmailMessenger;
            if (email.CanSendEmail)
                email.SendEmail("dontlook@me.org", "Email from app", "This is a test email from the app");

            /*Alternate / more difficult way: 
            var email = CrossMessaging.Current.EmailMessenger;
            if (email.CanSendEmail) {
                var message = new EmailMessageBuilder()
                    .To("dontlook@me.org")
                    .Subject("Email from app")
                    .Body("This is a test email from the app")
                    .Build();

                email.SendEmail(message);
            }
            */
        }
        private void Call(object sender, EventArgs e)
        {
            var phone = CrossMessaging.Current.PhoneDialer;
            if (phone.CanMakePhoneCall)
                phone.MakePhoneCall("+4512345678", "Melika Pedersen");
        }
        private void Message(object sender, EventArgs e)
        {
            var message = CrossMessaging.Current.SmsMessenger;
            if (message.CanSendSms)
                message.SendSms("+4512345678", "Test message from app");
        }
    }
}