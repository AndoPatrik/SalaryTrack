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
    }
}
