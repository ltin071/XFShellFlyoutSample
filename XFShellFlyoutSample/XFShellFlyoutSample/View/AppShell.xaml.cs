
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFShellFlyoutSample.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppShell : Shell
	{
		public AppShell ()
		{
			InitializeComponent ();
		}
	}
}