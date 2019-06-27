using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFShellFlyoutSample.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TodoListPage : ContentPage
	{
		public TodoListPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var titleViewBound = Shell.GetTitleView(this).Bounds;
            DisplayInfo displayInfo = DeviceDisplay.MainDisplayInfo;
            double leftButtonWidth = displayInfo.Width / displayInfo.Density - titleViewBound.Width;
            TitleImage.Margin = new Thickness(0, 0, leftButtonWidth, 0);
        }
    }
}