using SalaryTrack.Helpers;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace SalaryTrack.View
{
    public sealed partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            this.InitializeComponent();
        }

        private void SaveChangesBtn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MessageDialog msg = new MessageDialog("Your changes has been saved!");
            msg.ShowAsync();
        }
    }
}
