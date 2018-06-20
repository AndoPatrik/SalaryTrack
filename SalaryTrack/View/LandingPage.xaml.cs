using SalaryTrack.View;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SalaryTrack
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            BasicElementSetup();

            this.InitializeComponent();
        }

        #region Setup Methods
        private void BasicElementSetup()
        {
            LandingFrame.Navigate(typeof(CalendarPage));
            TitleBarSetup();
        }

        private void TitleBarSetup()
        {
            ApplicationViewTitleBar formattableTitleBar = ApplicationView.GetForCurrentView().TitleBar;
            formattableTitleBar.ButtonBackgroundColor = Colors.Transparent;
            CoreApplicationViewTitleBar coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;
        }
        #endregion

        #region UI Element Actions
        private void ProfileBtn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            LandingFrame.Navigate(typeof(ProfilePage));
        }

        private void CalendarBtn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            LandingFrame.Navigate(typeof(CalendarPage));
        }

        private void OverviewBtn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            LandingFrame.Navigate(typeof(OverviewPage));
        }
        #endregion
    }
}
