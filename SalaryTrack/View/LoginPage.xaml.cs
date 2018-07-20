using SalaryTrack.Helpers;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace SalaryTrack.View
{

    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SignUpHelper.PasswordValidation(PasswordSignUpBox.Password, Password2SignUpBox.Password))
            {
                MessageDialog msg = new MessageDialog("You have been signed up! Log in with your account.");
                msg.ShowAsync();
            }  
        }
    }
}
