using SalaryTrack.View;
using Windows.UI.Xaml.Controls;

namespace SalaryTrack
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            BasicElementSetup();
        }

        private void BasicElementSetup()
        {
            LandingFrame.Navigate(typeof(CalendarPage));
        }
    }
}
