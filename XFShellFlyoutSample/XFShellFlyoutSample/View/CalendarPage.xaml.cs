
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace XFShellFlyoutSample.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalendarPage : ContentPage
	{
        private Image TitleImage;
        public CalendarPage()
        {
            InitializeComponent();
        }
    }
}